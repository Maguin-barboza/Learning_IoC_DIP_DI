using System;
using System.Collections.Generic;
using System.Text;

namespace Learning_IoC_DIP_DI
{
    public class DataAccesFactory
    {
        public static IDataAccess<Customer> GetDataAccessObj()
        {
            return new CustomerDataAcces();
        }
    }
}
