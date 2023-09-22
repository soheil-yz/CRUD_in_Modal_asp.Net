using AspNetCore;
using CRUD_in_Modal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ModalCRUD.Services;
using ModalCRUD.DbContext;
using ModalCRUD.Models;
using ModalCRUD.ViewModels;
using ModalCRUD.ViewModels;

namespace CRUD_in_Modal.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
                
        [HttpGet("load-product-modal-body")]
        public IActionResult LoadProductModalBody(int productId)
        {
            var result = _productService.FillCreateOrEditProductViewModal(productId);

            return PartialView("_productModalParial", result);    
        }
    }
}
    