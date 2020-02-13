using System;
using System.Collections.Generic;
using System.Text;

namespace Learning_IoC_DIP_DI
{
    public interface IDataAccess<T>
        where T: class
    {
        public string GetName(int Id);
    }
}
