namespace Learning_IoC_DIP_DI
{
    public class CustomerService
    {
        CustomerBusinessLogic _customerBL;

        public CustomerService()
        {
            _customerBL = new CustomerBusinessLogic();
            ((IDataAccessDependency)_customerBL).SetDependency(new CustomerDataAcces());
        }

        public string GetCustomerName(int Id)
        {
            return _customerBL.GetCustomerName(Id);
        }
    }
}
