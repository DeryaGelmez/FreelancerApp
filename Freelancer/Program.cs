using Freelancer.Entities;
using Freelancer.Services;
using Freelancer.Common;
using Freelancer.Abstract;

namespace Freelancer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var anotherCustomerInstance = new Customer
            {
                Id = Guid.NewGuid(),
                CreatedOn = DateTime.Now,
                FirstName = "Derya",
                LastName = "Gelmez",
                PhoneNumber = "544-123-4567"
            };

            NotepadService notepadService = new();

            string customerData = notepadService.GetOnNotepad("C:\\Users\\derya\\source\\repos\\Freelancer\\Freelancer\\Database\\Customers.txt");
            
            string[] splittedLines = customerData.Split('\n', StringSplitOptions.RemoveEmptyEntries);

            List<Customer> customers = new();

            foreach (var line in splittedLines)
            {
                Customer customer = new();
                customer.SetValuesCSV(line);
                customers.Add(customer);
            }
        }
    }
}