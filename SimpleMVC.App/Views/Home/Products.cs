using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpStore.ViewModels;
using SimpleMVC.Interfaces;
using SimpleMVC.Interfaces.Generic;

namespace SharpStore.Views.Home
{
    public class Products : IRenderable<IEnumerable<ProductViewModel>>
    {
        public string Render()
        {
            var sb = new StringBuilder();
            string content = File.ReadAllText("../../content/products.html");
            foreach (var viewModel in Model)
            {
                sb.Append(viewModel);
            }

            return string.Format(content, sb);
        }

        public IEnumerable<ProductViewModel> Model { get; set; }
    }
}
