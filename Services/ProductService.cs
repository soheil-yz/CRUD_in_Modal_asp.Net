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

        public bool CreateOrEditProducts(CreateOrEditProductViewModel createorEdite)
        {
            if (createorEdite.Id == 0)
            {
                var add = new Product()
                {
                    Barcode = createorEdite.Barcode,
                    Description = createorEdite.Description,
                    IsDelete = false,
                    Name = createorEdite.Name,
                    Price = createorEdite.Price,
                    Type = createorEdite.Type,

                };
                _context.Add(add);
                _context.SaveChanges();

                return true;
            }
        }




    }
}
