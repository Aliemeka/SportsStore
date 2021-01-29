using System;
using System.Collections.Generic;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Data;
using SportsStore.Domain.Entities;

namespace SportsStore.Domain.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly StoreDbContext _context;

        public ProductRepository(StoreDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Command to get all products in the database
        /// </summary>
        /// <returns>list of products</returns>
        public IEnumerable<Product> GetAllProducts()
        {
            return _context.Products;
        }

        /// <summary>
        /// Gets a product that matches the id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>product</returns>
        public Product GetProduct(int id)
        {
            var product = _context.Products.Find(id);
            return product;
        }

        /// <summary>
        /// Adds a product to product table
        /// </summary>
        /// <param name="product"></param>
        /// <returns>product</returns>
        public Product AddProduct(Product product)
        {
            var newProduct = product;
            _context.Products.Add(newProduct);
            return newProduct;
        }

        /// <summary>
        /// Deletes a product from the products table
        /// </summary>
        /// <param name="id"></param>
        /// <returns>product</returns>
        public Product DeleteProduct(int id)
        {
            var delProduct = _context.Products.Find(id);
            if (delProduct != null)
                _context.Products.Remove(delProduct);
            return delProduct;
        }
    }
}
