namespace Learning_IoC_DIP_DI
{
    public class CustomerBusinessLogic: IDataAccessDependency
    {
        private IDataAccess<Customer> _dataAccess;
        
        public CustomerBusinessLogic() {   }

        public string GetCustomerName(int Id)
        {
            return this._dataAccess.GetName(Id);
        }

        public void SetDependency(IDataAccess<Customer> costumerDataAccess)
        {
            this._dataAccess = costumerDataAccess;
        }
    }
}
