using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpStore.Data;
using SharpStore.ViewModels;

namespace SharpStore.Services
{
    public class ProductsService : Service
    {
        public ProductsService(SharpStoreContext context) : base(context)
        {
        }

        public IEnumerable<ProductViewModel> GetProducts(string productName)
        {
            var knives = Data.Data.Context.Knives.Where(x=>x.Name.Contains(productName)).ToArray();
            var viewModels = new List<ProductViewModel>();

            foreach (var knife in knives)
            {
                viewModels.Add(new ProductViewModel()
                {
                    Id = knife.Id,
                    Name = knife.Name,
                    Price = knife.Price,
                    ImageURL = knife.ImageURL
                });
            }

            return viewModels;
        }

        public IEnumerable<AdminPanelProductViewModel> GetAdminPanelProducts()
        {
            var knives = Data.Data.Context.Knives.ToArray();
            var viewModels = new List<AdminPanelProductViewModel>();

            foreach (var knife in knives)
            {
                var model = new AdminPanelProductViewModel()
                {
                    Id = knife.Id,
                    Name = knife.Name,
                    Price = knife.Price,
                    Url = knife.ImageURL
                };
                
                viewModels.Add(model);
            }

            return viewModels;
        }
    }
}
