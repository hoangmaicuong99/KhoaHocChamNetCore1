using System;
using System.Collections.Generic;
using System.Text;
using DISampleService.Dtos;

namespace DISampleService
{
    public class ProductBesterService : IProductService
    {
        public List<ProductViewModel> GetAll()
        {
            return new List<ProductViewModel>
            {
                new ProductViewModel{ id = 1, name = "IPhone P"},
                new ProductViewModel{ id = 2, name = "IPhone X P"},
                new ProductViewModel{ id = 3, name = "IPhone SX P"}
            };
        }
    }
}
