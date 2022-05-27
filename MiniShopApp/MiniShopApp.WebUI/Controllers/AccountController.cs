using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MiniShopApp.WebUI.Identity;
using MiniShopApp.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniShopApp.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<User> _userManager;
        private SignInManager<User> _signInManager;
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(string ReturnUrl=null) 
        {
            return View(
                   new LoginModel()
                   {
                       ReturnUrl = ReturnUrl
                   }
                );
        }
        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            //Burada login işlemlerini gerçekleştireceğiz.
            return View(); 
        }

        public IActionResult Register() 
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = new User()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                UserName = model.UserName,
                Email = model.Email
            };

            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)//Create işlemi başarılıysa
            {
                //Mail onay işlemleri
                //TOKEN işlemleri
                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                
                var url = Url.Action("ConfirmEmail", "Account", new
                {
                    userId = user.Id,
                    token = code
                });
                //mail gönderme işlemleri


            }
            return View();
        }
    }
}
