using System;
using System.Collections.Generic;
using System.Text;

namespace Learning_IoC_DIP_DI
{
    public class CustomerDataAcces : IDataAccess<Customer>
    {
        public string GetName(int Id)
        {
            return "Dummy Customer Name";
        }
    }
}
