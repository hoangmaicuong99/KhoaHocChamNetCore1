using System;
using System.Collections.Generic;
using System.Text;
using DISample.Services.Dtos;

namespace DISample.Services
{
    class ProductService
    {
        public List<ProductViewModel> GetAll()
        {
            return new List<ProductViewModel>
            {
                new ProductViewModel{ id = 1 , name = "Iphone X" },
                new ProductViewModel{ id=2, name = "Xiao Mi"},
                new ProductViewModel { id = 3, name = "Samsung"}
            };
        }
    }
}
