using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModalCRUD.Models;
 
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


        
    }
}
