using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpStore.BindingModels
{
    public class PurchaseBinding
    {
        public int knifeId { get; set; }

        public string BuyerName { get; set; }

        public string BuyerPhone { get; set; }

        public string BuyerAddress { get; set; }

        public string DeliveryType { get; set; }
    }
}
