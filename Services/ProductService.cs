using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModalCRUD.DbContext;
using ModalCRUD.Models;
using ModalCRUD.ViewModels;

namespace ModalCRUD.Services
{
    public class ProductService : IProductService
    {
        #region Ctor

        private ModalCRUDDbContext _context;

        public ProductService(ModalCRUDDbContext context)
        {
            _context = context;
        }
        #endregion

        public bool CreateOrEditProducts(CreateOrEditProductViewModel createOrEdite)
        {
            if (createOrEdite.Id == 0)
            {
                var add = new Product()
                {
                    Barcode = createOrEdite.Barcode,
                    Description = createOrEdite.Description,
                    IsDelete = false,
                    Name = createOrEdite.Name,
                    Price = createOrEdite.Price,
                    Type = createOrEdite.Type,

                };
                _context.Add(add);
                _context.SaveChanges();

                return true;
            }
            var product = _context.Products.FirstOrDefault(s => s.Id == createOrEdite.Id && !s.IsDelete);
            if (product == null)
            {
                return false;
            }
            product.Name = createOrEdite.Name;
            product.Price = createOrEdite.Price;
            product.Type = createOrEdite.Type;
            product.Description = createOrEdite.Description;
            product.Barcode = createOrEdite.Barcode;

            _context.Update(product);
            _context.SaveChanges();

            return true;
        }

        public CreateOrEditProductViewModel FillCreateOrEditProductViewModal(int productId)
        {
            if (productId == 0)
            {
                return null;

            }
            var product = _context.Products.FirstOrDefault(p => p.Id == productId && !p.IsDelete);
            if (product == null)
            {
                return null;
            }
            return new CreateOrEditProductViewModel()
            {
                Name = product.Name,
                Price = product.Price,
                Type = product.Type,
                Description = product.Description,
                Barcode = product.Barcode,
                Id = product.Id,

            };  
        }
    }
}
