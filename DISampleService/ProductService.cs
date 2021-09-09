using System;
using System.Collections.Generic;
using System.Text;
using DISampleService.Dtos;

namespace DISampleService
{
    public class ProductService : IProductService
    {
        public List<ProductViewModel> GetAll()
        {
            return new List<ProductViewModel>
            {
                new ProductViewModel{ id = 1, name = "IPhone"},
                new ProductViewModel{ id = 2, name = "IPhone X"},
                new ProductViewModel{ id = 3, name = "IPhone SX"}
            };
        }
    }
}
