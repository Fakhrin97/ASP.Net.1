using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var catigories = new List<Catigorie>
            {
                new Catigorie
                {
                    Id = 1,
                    Name = "Salvar",
                    ImageUrl ="cat-1.jpg"
                },
                new Catigorie
                {
                    Id = 2,
                    Name = "Koynek",
                    ImageUrl ="cat-2.jpg"
                },
                new Catigorie
                {
                    Id = 3,
                    Name = "Makasin",
                    ImageUrl ="cat-3.jpg"
                },
                new Catigorie
                {
                    Id = 4,
                    Name = "Papaq",
                    ImageUrl ="cat-4.jpg"
                },
                new Catigorie
                {
                    Id = 5,
                    Name = "Corab",
                    ImageUrl ="cat-5.jpg"
                },
                new Catigorie
                {
                    Id = 6,
                    Name = "Sherf",
                    ImageUrl ="cat-6.jpg"
                }
            };
            var dresses = new List<Dress>
            {
                new Dress
                {
                    Id = 1,
                    Catigorie = catigories[0],
                    Name = "Colorful Stylish Shirt1",
                    Price = 100,
                    ImageUrl="product-1.jpg"
                    
                },
                new Dress
                {
                    Id = 2,
                    Catigorie = catigories[1],
                    Name = "Colorful Stylish Shirt2",
                    Price = 1001,
                    ImageUrl="product-2.jpg"

                },
                new Dress
                {
                    Id = 3,
                    Catigorie = catigories[2],
                    Name = "Colorful Stylish Shirt3",
                    Price = 1010,
                    ImageUrl="product-3.jpg"

                },
                new Dress
                {
                    Id = 4,
                    Catigorie = catigories[3],
                    Name = "Colorful Stylish Shirt4",
                    Price = 1100,
                    ImageUrl="product-4.jpg"
                },
                new Dress
                {
                    Id = 5,
                    Catigorie = catigories[4],
                    Name = "Colorful Stylish Shirt5",
                    Price = 200,
                    ImageUrl="product-5.jpg"
                },
                new Dress
                {
                    Id = 6,
                    Catigorie = catigories[5],
                    Name = "Colorful Stylish Shirt6",
                    Price = 1500,
                    ImageUrl="product-6.jpg"
                },
                new Dress
                {
                    Id = 7,
                    Catigorie = catigories[4],
                    Name = "Colorful Stylish Shirt7",
                    Price = 500,
                    ImageUrl="product-7.jpg"
                },
                new Dress
                {
                    Id = 8,
                    Catigorie = catigories[2],
                    Name = "Colorful Stylish Shirt8",
                    Price = 150,
                    ImageUrl="product-8.jpg"
                },


            };
            var sliders = new List<Slider>
            {
                new Slider
                {
                    Id = 1,
                    Discount = 10,
                    Tittle = "Ilin Debi",
                    ImageUrl = "cat-1.jpg"
                },
                new Slider
                {
                    Id = 2,
                    Discount = 20,
                    Tittle = "Temiz Deri",
                    ImageUrl = "cat-2.jpg"
                },
                new Slider
                {
                    Id = 3,
                    Discount = 30,
                    Tittle = "Black Friday",
                    ImageUrl = "cat-3.jpg"
                },
                new Slider
                {
                    Id = 4,
                    Discount = 50,
                    Tittle = "Yalniz Nermanov Flialinda",
                    ImageUrl = "cat-4.jpg"
                },
            };
            var featureds = new List<Featured>
            {
                new Featured
                {
                    Id = 1,
                    ClassName = "fa fa-check text-primary m-0 mr-3",
                    Tittle = "Quality Product"
                },
                 new Featured
                {
                    Id = 2,
                    ClassName = "fa fa-shipping-fast text-primary m-0 mr-2",
                    Tittle = "Free Shipping"
                },
                  new Featured
                {
                    Id = 3,
                    ClassName = "fas fa-exchange-alt text-primary m-0 mr-3",
                    Tittle = "14-Day Return"
                },
                   new Featured
                {
                    Id = 4,
                    ClassName = "fa fa-phone-volume text-primary m-0 mr-3",
                    Tittle = "24/7 Support"
                },
            };
            var verdors = new List<Vendor>
            {
                new Vendor
                {
                    Id = 1,
                    ImageUrl = "vendor-1.jpg"

                },
                new Vendor
                {
                    Id = 2,
                    ImageUrl = "vendor-2.jpg"

                },
                new Vendor
                {
                    Id = 3,
                    ImageUrl = "vendor-3.jpg"

                },
                new Vendor
                {
                    Id = 4,
                    ImageUrl = "vendor-4.jpg"

                },
                new Vendor
                {
                    Id = 5,
                    ImageUrl = "vendor-5.jpg"

                },new Vendor
                {
                    Id = 6,
                    ImageUrl = "vendor-6.jpg"

                },new Vendor
                {
                    Id = 7,
                    ImageUrl = "vendor-7.jpg"

                },new Vendor
                {
                    Id = 8,
                    ImageUrl = "vendor-8.jpg"

                },

            };

            var homeVievModel = new HomeVievModel
            {
                Catigories = catigories,
                Sliders = sliders,
                Featureds = featureds,
                Dresses = dresses,  
                Vendors=verdors,
            };

            return View(homeVievModel);
        }
    }
}
