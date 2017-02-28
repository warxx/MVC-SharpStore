using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpStore.BindingModels;
using SharpStore.Data;
using SharpStore.Models;

namespace SharpStore.Services
{
    public class BuyService : Service
    {
        public BuyService(SharpStoreContext context) : base(context)
        {
        }

        public void AddPurchaseFromBind(PurchaseBinding pbm)
        {
            var purchase = new Purchase()
            {
                BuyerName = pbm.BuyerName,
                BuyerAddress = pbm.BuyerAddress,
                BuyerPhone = pbm.BuyerPhone,
                DeliveryType = (DeliveryType) Enum.Parse(typeof(DeliveryType), pbm.DeliveryType)
            };

            context.Purchases.Add(purchase);
            context.SaveChanges();
        }

        public bool IsKnifeValid(int knifeId)
        {
            var knife = context.Knives.Find(knifeId);
            if (knife == null)
            {
                return false;
            }

            return true;
        }
    }
}
