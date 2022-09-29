using ModelLibrary;

namespace BookShopCafe.Managers
{
    public interface ICustomerManager
    {

        List<Customer> Get();
        Customer Create(Customer customer);
        Customer Update(int id, Customer customer);
        Customer Delete(int id);

    }
}
