using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IOrderService
    {
        IDataResult<List<Order>> GetAll();
        //IDataResult<List<ProductDetailDto>> GetProductDetail(); WRL
        IResult Add(Order order);
        IResult Update(Order order);
        IDataResult<Order> GetById(int orderId);
        //IResult AddTransactionalTest(Product product); WRL
    }
}
