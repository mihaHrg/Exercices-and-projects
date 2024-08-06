using System.Data.SqlClient;
using Databases.Models;

namespace Databases.AdoNet
{
    public class CustomersAdoNetRepository
    {
        public void ReadCustomersWithTheirAddresses()
        {
            var connectionString = "Server=localhost;Database=MyTestDatabase;User Id=sa;Password=SQLServerPassword123;TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand readAllCustomersWithTheirAddresses = 
                    new SqlCommand("SELECT c.Id AS CustomerId, c.Name, c.Age, a.Id AS AddressId, a.StreetName, a.StreetNumber, a.City " +
                    "FROM Customers c " +
                    "INNER JOIN Addresses a on c.AddressId = a.Id;", connection);
                SqlDataReader allCustomersWithTheirAddresses = readAllCustomersWithTheirAddresses.ExecuteReader();

                List<Customer> customers = new List<Customer>();
                while (allCustomersWithTheirAddresses.Read())
                {
                    Customer customer = new Customer
                    {
                        Id = (int)allCustomersWithTheirAddresses["CustomerId"],
                        Name = (string)allCustomersWithTheirAddresses["Name"],
                        Age = (int)allCustomersWithTheirAddresses["Age"],
                        Address = new Address
                        {
                            Id = (int)allCustomersWithTheirAddresses["AddressId"],
                            StreetName = (string)allCustomersWithTheirAddresses["StreetName"],
                            StreetNumber = (int)allCustomersWithTheirAddresses["StreetNumber"],
                            City = (string)allCustomersWithTheirAddresses["City"],
                        }

                    };

                    customers.Add(customer);
                }

                Console.WriteLine("Read all customers with their addresses: ");
                foreach (Customer customer in customers)
                {
                    Console.WriteLine($"Name: {customer.Name}, Age: {customer.Age}, City: {customer.Address.City}.");
                }
            }
        }
    }
}
