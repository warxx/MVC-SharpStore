using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpStore.Services;
using SharpStore.ViewModels;
using SimpleMVC.Attributes.Methods;
using SimpleMVC.Controllers;
using SimpleMVC.Interfaces;
using SimpleMVC.Interfaces.Generic;

namespace SharpStore.Controllers
{
    public class AdminController : Controller
    {
        [HttpGet]
        public IActionResult<IEnumerable<AdminPanelProductViewModel>> Index()
        {
            var service = new ProductsService(Data.Data.Context);
            var viewModels = service.GetAdminPanelProducts();

            return this.View(viewModels);
        }
    }
}
