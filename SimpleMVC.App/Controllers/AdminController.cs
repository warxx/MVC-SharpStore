using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpStore.Services;
using SharpStore.Utilities;
using SharpStore.ViewModels;
using SimpleHttpServer.Models;
using SimpleMVC.Attributes.Methods;
using SimpleMVC.Controllers;
using SimpleMVC.Interfaces;
using SimpleMVC.Interfaces.Generic;

namespace SharpStore.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult<IEnumerable<AdminPanelProductViewModel>> Index(HttpSession session, HttpResponse response)
        {
            var user = AuthenticationManager.GetAuthenticatedUser(session.Id);
            if (user == null)
            {
                this.Redirect(response, "/login/login");
                return null;
            }
            var service = new ProductsService(Data.Data.Context);
            var viewModels = service.GetAdminPanelProducts();

            return this.View(viewModels);
        }

        [HttpGet]
        public IActionResult Logout(HttpResponse response, HttpSession session)
        {
            AuthenticationManager.Logout(session.Id, response);

            this.Redirect(response, "/home/index");
            return null;
        }
    }
}
