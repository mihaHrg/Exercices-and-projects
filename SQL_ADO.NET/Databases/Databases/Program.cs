using Databases.AdoNet;

Console.WriteLine("-----Books-----");
BooksAdoNetRepository booksAdoNetRepository = new BooksAdoNetRepository();
booksAdoNetRepository.ManageBooks();

Console.WriteLine();
Console.WriteLine("-----Customers-----");
CustomersAdoNetRepository customersAdoNetRepository = new CustomersAdoNetRepository();
customersAdoNetRepository.ReadCustomersWithTheirAddresses();

Console.WriteLine();
Console.WriteLine("-----Addresses-----");
AddressesAdoNetRepository addressesAdoNetRepository = new AddressesAdoNetRepository();
addressesAdoNetRepository.ManageAddresses();