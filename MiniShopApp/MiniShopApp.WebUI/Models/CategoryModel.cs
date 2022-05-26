using MiniShopApp.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MiniShopApp.WebUI.Models
{
    public class CategoryModel
    {
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Kategori ismi zorunludur!")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Kategori ismi 5-50 karakter uzunluğunda olmalıdır!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Açıklama zorunludur!")]
        [StringLength(500, MinimumLength = 20, ErrorMessage = "Açıklama 20-500 karakter uzunluğunda olmalıdır!")]
        public string Description { get; set; }
        public string Url { get; set; }
        //public List<ProductCategory> ProductCategories { get; set; }
    }
}
