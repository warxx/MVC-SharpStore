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
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Login(HttpResponse response, HttpSession session)
        {
            var authUser = AuthenticationManager.GetAuthenticatedUser(session.Id);
            if (authUser != null)
            {
                this.Redirect(response, "/admin/index");
                return null;
            }


            return this.View();
        }

        public IActionResult Login(HttpResponse response, HttpSession session, LoginUserBindingModel lubm)
        {

            var service = new LoginService(Data.Data.Context);

            var user = service.GetCorrespondingUser(lubm);
            if (user == null)
            {
                this.Redirect(response, "/login/login");
                return null;
            }

            service.LoginUser(session.Id, user);
            this.Redirect(response, "/home/index");
            return null;
        }
    }
}
