using Databases.Models;
using System.Data.SqlClient;

namespace Databases.AdoNet
{
    public class AddressesAdoNetRepository
    {
        public void ManageAddresses()
        {
            // create connection string
            var connectionString = "Server=localhost;Database=MyTestDatabase;User Id=sa;Password=SQLServerPassword123;TrustServerCertificate=True";

            // open a connection and use it in order to execute the following two methods
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                CountAddresses(connection);
                ReadAddressesOrderedByStreetNameAndThenStreetNumber(connection);
            }
        }

        public void CountAddresses(SqlConnection connection)
        {
            // add your code here
            SqlCommand readNumberOfAddresses = new SqlCommand("SELECT COUNT(*) FROM Addresses", connection);
            var numberOfAddresses = readNumberOfAddresses.ExecuteScalar();

            Console.WriteLine("Number of addresses: " + numberOfAddresses);
        }

        public void ReadAddressesOrderedByStreetNameAndThenStreetNumber(SqlConnection connection)
        {
            // add your code here
            Console.WriteLine("Read all addresses:");
            SqlCommand readAllAddresses = new SqlCommand("SELECT * FROM Addresses", connection);
            SqlDataReader allAddresses = readAllAddresses.ExecuteReader();

            while (allAddresses.Read())
            {
                Address address = new Address
                {
                    Id = (int)allAddresses["Id"],
                    StreetName = (string)allAddresses["StreetName"],
                    StreetNumber = (int)allAddresses["StreetNumber"],
                    City = (string)allAddresses["City"]
                };
                Console.WriteLine($"{address.Id}, {address.StreetName}, {address.StreetNumber}, {address.City}");
            }
        }

    }
}
