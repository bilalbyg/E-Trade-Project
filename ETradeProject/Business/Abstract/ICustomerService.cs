using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        //WRL : Will refactor later
        IDataResult<List<Customer>> GetAll();
        //IDataResult<List<CustomerDetailDto>> GetProductDetail(); WRL
        IResult Add(Customer customer);
        IResult Update(Customer customer);
        IDataResult<Customer> GetById(int customerId);
        //IResult AddTransactionalTest(Product product); WRL
    }
}
