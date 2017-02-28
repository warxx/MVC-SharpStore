using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpStore.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string ImageURL { get; set; }

        public override string ToString()
        {
            return "<div class=\"col-lg-4\">\r\n" +
                   "<div class=\"card\">\r\n" +
                   "<img class=\"img-thumbnail\" " +
                   $"src=\"{ImageURL}\" " +
                   "alt=\"Knife Image\">\r\n" +
                   "<div class=\"card-block\">\r\n" +
                   $"<h3 class=\"card-title\">{Name}</h3>\r\n" +
                   $"<p class=\"card-text\">${Price}</p>\r\n" +
                   $"<a href =\"/home/buy?knifeId={this.Id}\"><button class=\"btn btn-primary\">Buy NOW!</button></a>\r\n" +
                   "</div>\r\n" +
                   "</div>\r\n" +
                   "</div>";
        }
    }
}
