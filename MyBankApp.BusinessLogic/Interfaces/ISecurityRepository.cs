using MyBankApp.Models;

namespace MyBankApp.BusinessLogic
{
    public interface ISecurityRepository
    {
        bool GrantAccess(string username, string password, out int customerId);
        Security NewSecurityDetails(string username, string password, string firstName, string lastName, string email);
    }
}