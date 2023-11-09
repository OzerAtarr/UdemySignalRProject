using SignalR.BusinessLayer.Abstract;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductService _productService;

        public ProductManager(IProductService productService)
        {
            _productService = productService;
        }

        public void TAdd(Product entity)
        {
            _productService.TAdd(entity);
        }

        public void TDelete(Product entity)
        {
            _productService.TDelete(entity);
        }

        public Product TGetByID(int id)
        {
            return _productService.TGetByID(id);    
        }

        public List<Product> TGetListAll()
        {
            return _productService.TGetListAll();
        }

        public void TUpdate(Product entity)
        {
            _productService.TUpdate(entity);
        }
    }
}
