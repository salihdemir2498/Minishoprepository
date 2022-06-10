using Iyzipay;
using Iyzipay.Model;
using Iyzipay.Request;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MiniShopApp.Business.Abstract;
using MiniShopApp.Core;
using MiniShopApp.Entity;
using MiniShopApp.WebUI.Identity;
using MiniShopApp.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderItem = MiniShopApp.Entity.OrderItem;

namespace MiniShopApp.WebUI.Controllers
{
    [Authorize]
    public class CardController : Controller
    {
        private ICardService _cardService;
        private UserManager<User> _userManager;
        private IOrderService _orderService;

        public CardController(ICardService cardService, UserManager<User> userManager, IOrderService orderService)
        {
            _cardService = cardService;
            _userManager = userManager;
            _orderService = orderService;
        }

        public IActionResult Index()
        {
            var card = _cardService.GetCardByUserId(_userManager.GetUserId(User));
            var model = new CardModel()
            {
                CardId = card.Id,
                CardItems = card.CardItems.Select(i => new CardItemModel()
                {
                    CartItemId=i.Id,
                    ProductId=i.ProductId,
                    Name=i.Product.Name,
                    Price=(double)i.Product.Price,
                    ImageUrl=i.Product.ImageUrl,
                    Quantity=i.Quantity
                }).ToList()
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult AddToCard(int productId, int quantity)
        {
            //User bilgisinden yararlanarak UserId bulunacak.
            //UserId, productId, quantity bilgilerini kullanıp bize karta ürün ekleme
            //işlemini yapıp dönecek bir metot hazırlayalım
            var userId = _userManager.GetUserId(User);
            _cardService.AddToCard(userId, productId, quantity);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult DeleteFromCard(int productId)
        {
            var userId = _userManager.GetUserId(User);
            _cardService.DeleteFromCard(userId,productId);
            return RedirectToAction("Index");
        }
        public IActionResult CheckOut()
        {
            var userId = _userManager.GetUserId(User);
            var card = _cardService.GetCardByUserId(userId);
            var orderModel = new OrderModel();
            orderModel.CardModel = new CardModel()
            {
                CardId = card.Id,
                CardItems = card.CardItems.Select(i => new CardItemModel()
                {
                    CartItemId=i.Id,
                    ProductId=i.ProductId,
                    Name=i.Product.Name,
                    Price=(double)i.Product.Price,
                    ImageUrl=i.Product.ImageUrl,
                    Quantity=i.Quantity
                }).ToList()
            };
            return View(orderModel);
        }

        [HttpPost]
        public IActionResult CheckOut(OrderModel orderModel)
        {
            if (ModelState.IsValid)
            {
                var userId = _userManager.GetUserId(User);
                var card = _cardService.GetCardByUserId(userId);
                orderModel.CardModel = new CardModel()
                {
                    CardId = card.Id,
                    CardItems = card.CardItems.Select(i => new CardItemModel()
                    {
                        CartItemId=i.Id,
                        ProductId=i.ProductId,
                        Name=i.Product.Name,
                        Price=(double)i.Product.Price,
                        ImageUrl=i.Product.ImageUrl,
                        Quantity=i.Quantity
                    }).ToList()
                };
                //Ödeme işlemine başla

                var payment = PaymentProcess(orderModel);
                if (payment.Status=="success")
                {
                    SaveOrder(orderModel,payment,userId);
                    _cardService.DeleteFromCardItems();
                    TempData["Message"] = JobManager.CreateMessage("BİLGİ","Ödemeniz başarıyla gerçekleşmiştir!","success");
                    return Redirect("~/");
                }
                else
                {
                    TempData["Message"] = JobManager.CreateMessage("BİLGİ", payment.ErrorMessage , "danger");
                    return View(orderModel);
                }
            }
            return View(orderModel);
        }

        private void SaveOrder(OrderModel orderModel, Payment payment, string userId)
        {
            var order = new Order();
            order.OrderNumber = new Random().Next(111111111, 999999999).ToString();
            order.OrderState = EnumOrderState.Completed;
            order.PaymentType = EnumPaymentType.CreditCard;
            order.PaymentId = payment.PaymentId;
            order.ConversationId = payment.ConversationId;
            order.OrderDate = new DateTime();
            order.FirstName = orderModel.FirstName;
            order.LastName = orderModel.LastName;
            order.UserId = userId;
            order.Address = orderModel.Address;
            order.City = orderModel.City;
            order.Phone = orderModel.Phone;
            order.Email = orderModel.Email;
            order.Note = orderModel.Note;

            order.OrderItems = new List<OrderItem>();
            foreach (var item in orderModel.CardModel.CardItems)
            {
                var orderItem = new OrderItem()
                { 
                    Price=item.Price,
                    Quantity=item.Quantity,
                    ProductId=item.ProductId,
                };
                order.OrderItems.Add(orderItem);
            }
            _orderService.Create(order);
        }

        private static int LuhnControl(List<int> numbers, int toplam = 0)
        {


            if (numbers.Count == 16)
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (i % 2 == 1)
                    {
                        if (numbers[i] > 9)
                        {
                            numbers[i] = (numbers[i] / 10) + (numbers[i] % 10);
                        }


                        toplam += 2 * numbers[i];
                        if (toplam % 10 == 0)
                        {
                            return toplam;
                        }
                    }

                }
            }
            return 1;

        }

        private Payment PaymentProcess(OrderModel orderModel)
        {
            Options options = new Options();
            options.ApiKey = "sandbox-i6eS7vk2P5B55jKmFopT3LLLqaQYXMQg";
            options.SecretKey = "sandbox-P8XDsTPNW9dWfM6G1ynCqQoWezLuXqG0";
            options.BaseUrl = "https://sandbox-api.iyzipay.com";

            CreatePaymentRequest request = new CreatePaymentRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = new Random().Next(111111111,999999999).ToString();
            request.Price = orderModel.CardModel.TotalPrice().ToString();
            request.PaidPrice = orderModel.CardModel.TotalPrice().ToString();
            request.Currency = Currency.TRY.ToString();
            request.Installment = 1;
            request.BasketId = "B67832";
            request.PaymentChannel = PaymentChannel.WEB.ToString();
            request.PaymentGroup = PaymentGroup.PRODUCT.ToString();

            PaymentCard paymentCard = new PaymentCard();
            paymentCard.CardHolderName = orderModel.CardName;
            //Card number Luhn Algoritması ile kontrol edilmeli 
            paymentCard.CardNumber = orderModel.CardNumber;
            paymentCard.ExpireMonth = orderModel.ExpirationMonth;
            paymentCard.ExpireYear = orderModel.ExpirationYear;
            paymentCard.Cvc = orderModel.Cvc;
            paymentCard.RegisterCard = 0;
            request.PaymentCard = paymentCard;

            Buyer buyer = new Buyer();
            buyer.Id = "BY789";
            buyer.Name = orderModel.FirstName;
            buyer.Surname = orderModel.LastName;
            buyer.GsmNumber = orderModel.Phone;
            buyer.Email = orderModel.Email;
            buyer.IdentityNumber = "74300864791";
            buyer.LastLoginDate = "2015-10-05 12:43:35";
            buyer.RegistrationDate = "2013-04-21 15:12:09";
            buyer.RegistrationAddress = orderModel.Address;
            buyer.Ip = "85.34.78.112";
            buyer.City = orderModel.City;
            buyer.Country = "Turkey";
            buyer.ZipCode = "34732";
            request.Buyer = buyer;

            Address shippingAddress = new Address();
            shippingAddress.ContactName = "Jane Doe";
            shippingAddress.City = "Istanbul";
            shippingAddress.Country = "Turkey";
            shippingAddress.Description = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
            shippingAddress.ZipCode = "34742";
            request.ShippingAddress = shippingAddress;

            Address billingAddress = new Address();
            billingAddress.ContactName = "Jane Doe";
            billingAddress.City = "Istanbul";
            billingAddress.Country = "Turkey";
            billingAddress.Description = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
            billingAddress.ZipCode = "34742";
            request.BillingAddress = billingAddress;

            List<BasketItem> basketItems = new List<BasketItem>();
            foreach (var item in orderModel.CardModel.CardItems)
            {
                BasketItem basketItem = new BasketItem();
                basketItem.Id = item.ProductId.ToString();
                basketItem.Name = item.Name;
                basketItem.Category1 = "General";
                basketItem.ItemType = BasketItemType.PHYSICAL.ToString();
                basketItem.Price = (item.Quantity*item.Price).ToString();
                basketItems.Add(basketItem);
            }


            request.BasketItems = basketItems;

            return Payment.Create(request, options);
        }
    }
}
