using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpStore.ViewModels;
using SimpleMVC.Interfaces;
using SimpleMVC.Interfaces.Generic;

namespace SharpStore.Views.Products
{
    public class Orders : IRenderable<IEnumerable<AllOrdersViewModel>>
    {
        public string Render()
        {
            string content = File.ReadAllText("../../content/orders.html");

            var sb = new StringBuilder();

            foreach (var viewModel in Model)
            {
                sb.Append(viewModel);
            }

            return string.Format(content, sb);
        }

        public IEnumerable<AllOrdersViewModel> Model { get; set; }
    }
}
