using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpStore.Models
{
    public class Purchase
    {
        public int Id { get; set; }

        public string BuyerName { get; set; }

        public string BuyerPhone { get; set; }

        public string BuyerAddress { get; set; }

        public DeliveryType DeliveryType { get; set; }
    }

    public enum DeliveryType
    {
        Express, Economic
    }
}
