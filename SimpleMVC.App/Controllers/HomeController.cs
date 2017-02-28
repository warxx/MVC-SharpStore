using System.Collections.Generic;
using System.Linq;
using SharpStore.BindingModels;
using SharpStore.Services;
using SharpStore.ViewModels;
using SimpleHttpServer.Models;
using SimpleMVC.Attributes.Methods;
using SimpleMVC.Controllers;
using SimpleMVC.Interfaces;
using SimpleMVC.Interfaces.Generic;

namespace SharpStore.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult About()
        {
            return View();
        }

        [HttpGet]
        public IActionResult<IEnumerable<ProductViewModel>> Products(string productName)
        {
            var productService = new ProductsService(Data.Data.Context);
            var viewModels = productService.GetProducts(productName);
            
            return View(viewModels);
        }

        [HttpGet]
        public IActionResult Contacts()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contacts(HttpResponse responce, MessageBinding msgBinding)
        {
            if (string.IsNullOrEmpty(msgBinding.Sender) || string.IsNullOrEmpty(msgBinding.Subject))
            {
                this.Redirect(responce, "/home/contacts");
                return null;
            }

            var msgService = new MessagesService(Data.Data.Context);
            msgService.AddMessageFromBind(msgBinding);

            this.Redirect(responce, "/home/index");
            return this.View();
        }

        [HttpGet]
        public IActionResult<BuyKnifeViewModel> Buy(HttpResponse response, int knifeId)
        {
            var service = new BuyService(Data.Data.Context);

            if (!service.IsKnifeValid(knifeId))
            {
                this.Redirect(response, "/home/products?productName=");
                return null;
            }

            return View(new BuyKnifeViewModel
            {
                KnifeId = knifeId
            });
        }

        [HttpPost]
        public IActionResult Buy(HttpResponse response, PurchaseBinding model)
        {
            var service = new BuyService(Data.Data.Context);

            service.AddPurchaseFromBind(model);
            this.Redirect(response, "/home/index");
            return null;
        }
    }
}
