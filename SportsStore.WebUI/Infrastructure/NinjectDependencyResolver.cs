using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Moq;
using Ninject;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;

namespace SportsStore.WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private readonly IKernel _kernel;

        public NinjectDependencyResolver(IKernel kernelParams)
        {
            _kernel = kernelParams;
            AddBindings();
        }

        public object GetService(Type serviceType) => _kernel.TryGet(serviceType);

        public IEnumerable<object> GetServices(Type serviceType) => _kernel.GetAll(serviceType);

        private void AddBindings()
        {
            // Initialize the mock
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            // Set up the mock
            mock.Setup(m => m.Products).Returns(new List<Product>
            {
                new Product { Name = "Nike Sneakers", Price = 60 },
                new Product() { Name="Gucci Top", Price = 55},
                new Product() { Name="Nova Gown", Price = 45}
            });

            _kernel.Bind<IProductRepository>().ToConstant(mock.Object);
        }
    }
}