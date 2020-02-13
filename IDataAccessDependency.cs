using System;
using System.Collections.Generic;
using System.Text;

namespace Learning_IoC_DIP_DI
{
    interface IDataAccessDependency
    {
        void SetDependency(IDataAccess<Customer> costumerDataAccess);
    }
}
