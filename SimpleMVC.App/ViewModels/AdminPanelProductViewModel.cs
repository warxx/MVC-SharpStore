using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpStore.ViewModels
{
    public class AdminPanelProductViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Url { get; set; }

        public decimal Price { get; set; }

        public override string ToString()
        {

            string temp =  "<div class=\"col-sm-4\">\r\n " +
                            "<img class=\"img-thumbnail\" " +
                            $"src=\"{this.Url}\" alt =\"\">\r\n" +
                            $"<h3>{this.Name}</h3>\r\n" +
                            $"<p>${this.Price:f2}</p>\r\n" +
                            $"<a href=\"/products/edit?knifeId={this.Id}\"><button class=\"btn btn-success\">Edit</button></a>\r\n" +
                            $"<a href=\"/products/delete?knifeId={this.Id}\"><button class=\"btn btn-danger\">Delete</button></a>\r\n" +
                            "</div>";
            return temp;
        }
    }
}
