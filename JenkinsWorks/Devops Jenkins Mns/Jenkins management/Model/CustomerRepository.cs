using CustomerList;
namespace Customerlist.Model
{
    public interface CustomerRepository
    {
        IEnumerable<Customer> GetAll();
        Customer Get(int id);
        Customer Add(Customer customer);
        void Remove(int id);
        
    }
}
