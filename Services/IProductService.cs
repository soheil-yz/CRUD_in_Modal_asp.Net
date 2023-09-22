using ModalCRUD.Models;
using ModalCRUD.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModalCRUD.Services
{
    public interface IProductService
    {
        bool CreateOrEditProducts(CreateOrEditProductViewModel createorEdite);
        CreateOrEditProductViewModel FillCreateOrEditProductViewModal(int productId);
    }
}
