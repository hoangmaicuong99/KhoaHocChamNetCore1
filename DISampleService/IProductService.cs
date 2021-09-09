using DISampleService.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DISampleService
{
    public interface IProductService
    {
        List<ProductViewModel> GetAll();
    }
}
