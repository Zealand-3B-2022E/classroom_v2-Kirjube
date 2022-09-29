using ModelLibrary;

namespace BookShopCafe.Managers
{
    public class CustomerManager : ICustomerManager
    {
        private static List<Customer> _books = new List<Customer>() { new Customer { Id = 1, Name = "Belial", Email= "Belial@gmail.com", Phone = "12345678"},
       new Customer { Id = 2, Name = "Behemoth", Email = "Behemoth@gmail.com", Phone = "23568945" } };
        public Customer Create(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Customer Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> Get()
        {
            throw new NotImplementedException();
        }

        public Customer Update(int id, Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
