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
    public class Buy : IRenderable<BuyKnifeViewModel>
    {
        public string Render()
        {
            string content = File.ReadAllText("../../content/buy.html");

            return string.Format(content, this.Model);
        }

        public BuyKnifeViewModel Model { get; set; }
    }
}
