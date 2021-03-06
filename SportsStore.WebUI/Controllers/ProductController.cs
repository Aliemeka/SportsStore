﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportsStore.Domain.Abstract;
using SportsStore.WebUI.Models;

namespace SportsStore.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepo;
        public int PageSize = 4;

        public ProductController(IProductRepository productRepository)
        {
            _productRepo = productRepository;
        }

        public ActionResult List(int page=1)
        {
            var model = new ProductsListViewModel
            {
                Products = _productRepo.GetAllProducts()
                    .OrderBy(p => p.ProductID)
                    .Skip((page-1)*PageSize)
                    .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = _productRepo.GetAllProducts().Count()
                }
            };
            
            return View(model);
        }
    }
}