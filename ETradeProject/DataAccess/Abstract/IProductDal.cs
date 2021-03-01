using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    // Operations in database about Product
    public interface IProductDal : IEntityRepository<Product>// Dal : Data Access Layer
    {
        List<ProductDetailDto> GetProductDetail();
    }
}
