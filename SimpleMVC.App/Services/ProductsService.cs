using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpStore.BindingModels;
using SharpStore.Data;
using SharpStore.Models;
using SharpStore.ViewModels;

namespace SharpStore.Services
{
    public class ProductsService : Service
    {
        public ProductsService(SharpStoreContext context) : base(context)
        {
        }


        public Knife IsKnifeIdExist(int knifeId)
        {
            var knife = context.Knives.Find(knifeId);
            return knife;
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
            var knives = this.context.Knives.ToArray();
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

        public void AddProduct(AddProductBindingModel model)
        {
            var knife = new Knife()
            {
                Name = model.Name,
                Price = model.Price,
                ImageURL = model.ImageUrl
            };

            this.context.Knives.Add(knife);
            this.context.SaveChanges();
        }

        public void DeleteProduct(int knifeId)
        {
            var knife = context.Knives.Find(knifeId);
            this.context.Knives.Remove(knife);
            this.context.SaveChanges();
        }

        public void Update(EditProductBindingModel model, int knifeId)
        {
            var knife = this.context.Knives.Find(knifeId);

            if (!string.IsNullOrEmpty(model.Name))
            {
                knife.Name = model.Name;
            }
            if (!string.IsNullOrEmpty(model.ImageUrl))
                knife.ImageURL = model.ImageUrl;

            this.context.SaveChanges();
        }
    }
}
