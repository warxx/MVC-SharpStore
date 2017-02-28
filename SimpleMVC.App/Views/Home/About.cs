using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleMVC.Interfaces;

namespace SharpStore.Views.Home
{
    public class About : IRenderable
    {
        public string Render()
        {
            return File.ReadAllText("../../content/about.html");
        }
    }
}
