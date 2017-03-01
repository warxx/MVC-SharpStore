using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpStore.Models;

namespace SharpStore.ViewModels
{
    public class AllOrdersViewModel
    {
        public int Id { get; set; }

        public string BuyerName { get; set; }

        public string BuyerPhone { get; set; }

        public string BuyerAddress { get; set; }

        public DeliveryType DeliveryType { get; set; }

        public override string ToString()
        {
            string temp = "<tr>" +
                          $"<td>{this.Id}</td>" +
                          $"<td>{this.BuyerName}</td>" +
                          $"<td>{this.BuyerPhone}</td>" +
                          $"<td>{this.BuyerAddress}</td>" +
                          $"<td>{this.DeliveryType}</td>" +
                          "<td class=\"btn btn-info\">Edit</td>" +
                          "</tr>";
            return temp;
        }
    }
}
