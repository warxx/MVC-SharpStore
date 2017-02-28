using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpStore.ViewModels;
using SimpleMVC.Interfaces;
using SimpleMVC.Interfaces.Generic;

namespace SharpStore.Views.Admin
{
    public class Index : IRenderable<IEnumerable<AdminPanelProductViewModel>>
    {
        public string Render()
        {
            var sb = new StringBuilder();
            string content = File.ReadAllText("../../content/adminPanel.html");

            foreach (var viewModel in Model)
            {
                sb.Append(viewModel);
            }

            return string.Format(content, sb);
        }

        public IEnumerable<AdminPanelProductViewModel> Model { get; set; }
    }
}
