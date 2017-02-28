using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleMVC.Interfaces;
using SimpleMVC.Interfaces.Generic;

namespace SharpStore.Views.Login
{
    public class Login : IRenderable
    {
        public string Render()
        {
            return File.ReadAllText("../../content/login.html");
        }
    }
}
