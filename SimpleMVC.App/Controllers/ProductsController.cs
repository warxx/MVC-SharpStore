using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpStore.BindingModels;
using SharpStore.Services;
using SharpStore.Utilities;
using SimpleHttpServer.Models;
using SimpleMVC.Attributes.Methods;
using SimpleMVC.Controllers;
using SimpleMVC.Interfaces;

namespace SharpStore.Controllers
{
    public class ProductsController : Controller
    {
        [HttpGet]
        public IActionResult Add(HttpSession session, HttpResponse response)
        {
            var user = AuthenticationManager.GetAuthenticatedUser(session.Id);
            if (user == null)
            {
                this.Redirect(response, "/login/login");
                return null;
            }

            return this.View();
        }

        [HttpPost]
        public IActionResult Add(AddProductBindingModel model, HttpResponse response, HttpSession session)
        {
            var user = AuthenticationManager.GetAuthenticatedUser(session.Id);
            if (user == null)
            {
                this.Redirect(response, "/login/login");
                return null;
            }

            var service = new ProductsService(Data.Data.Context);
            service.AddProduct(model);

            this.Redirect(response, "/admin/index");
            return null;
        }

        [HttpGet]
        public IActionResult Delete(HttpResponse response, int knifeId, HttpSession session)
        {
            var user = AuthenticationManager.GetAuthenticatedUser(session.Id);
            if (user == null)
            {
                this.Redirect(response, "/login/login");
                return null;
            }

            var service = new ProductsService(Data.Data.Context);
            service.DeleteProduct(knifeId);

            this.Redirect(response, "/admin/index");
            return null;
        }

        [HttpGet]
        public IActionResult Edit(HttpResponse response, HttpSession session)
        {
            var user = AuthenticationManager.GetAuthenticatedUser(session.Id);
            if (user == null)
            {
                this.Redirect(response, "/login/login");
                return null;
            }

            return this.View();
        }

        public IActionResult Edit(HttpResponse response, HttpSession session,
            EditProductBindingModel model, int knifeId)
        {

            var user = AuthenticationManager.GetAuthenticatedUser(session.Id);
            if (user == null)
            {
                this.Redirect(response, "/login/login");
                return null;
            }

            var service = new ProductsService(Data.Data.Context);

            var knife = service.IsKnifeIdExist(knifeId);
            if (knife == null)
            {
                this.Redirect(response, "/home/index");
                return null;
            }

            service.Update(model, knifeId);

            this.Redirect(response, "/admin/index");
            return null;
        }
    }
}
