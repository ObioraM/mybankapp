using MyBankApp.Models;

namespace MyBankApp.BusinessLogic
{
    public interface ICustomerRepository
    {
        Customer GetCustomer(int customerId);
        bool Save(Customer aCustomer);
    }
}