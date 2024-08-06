using hwOOP2.Exercise_1;
using hwOOP2.Exercise_2;
using hwOOP2.Exercise_3;
using hwOOP2.Exercise_4;
using hwOOP2.Exercise_5;
using hwOOP2.Exercise_6;
using hwOOP2.Exercise_7;
using System;
using System.Drawing;
using Rectangle = hwOOP2.Exercise_3.Rectangle;

Console.WriteLine("----ex1-----");
BankAccount myAccount = new BankAccount(1234567, "Ion Ionescu",1000);
myAccount.Deposit(500);
myAccount.Withdraw(200);

Console.WriteLine(myAccount.GetBalance());
List<Transaction> transactions = myAccount.GetTransactionHistory();
foreach (Transaction transaction in transactions)
{
    Console.WriteLine($"{transaction.Timestamp} : {transaction.Type} $ {transaction.Amount}");
}
myAccount.AccountNumber = 654321;
myAccount.AccountHolder = "Gheorghe Gheorghescu";
Console.WriteLine($"{myAccount.AccountHolder} - {myAccount.AccountNumber}");

Console.WriteLine("------ex2------");

Book book1=new Book("Mecanica inimii", "Mathias Malzieu", 158);
Console.WriteLine($"Title of book:{book1.GetTitle()}, author: {book1.GetAuthor()}, page count: {book1.GetPageCount()}, current page: {book1.GetCurrentPage()}");

book1.NextPage();
Console.WriteLine(book1.GetCurrentPage());

book1.NextPage();
book1.NextPage();
book1.NextPage();
Console.WriteLine(book1.GetCurrentPage());

book1.PreviousPage();
Console.WriteLine(book1.GetCurrentPage());

book1.Title = "Mecanica inimii (revised edition)";
Console.WriteLine(book1.GetTitle());

book1.Author="Mathias Malzieu JR (revised by Gabriel Garcia)";
Console.WriteLine(book1.GetAuthor());

Console.WriteLine("-------ex3--------");

Rectangle rectangle1 = new Rectangle("Green", 6, 8);
Rectangle rectangle2 = new Rectangle("Purplw", 10, 12);

Circle circle1 = new Circle("Orange",3);
Circle circle2 = new Circle("Yellow", 5);

List <Shape> shapes = new List<Shape> { rectangle1, rectangle2, circle1, circle2 };

foreach (Shape shape in shapes)
{
    shape.CalculateArea();
}

shapes.Sort((shape1, shape2)=> shape2.Area.CompareTo(shape1.Area));
foreach (Shape shape in shapes)
{
    Console.WriteLine(shape.Color+ ","+ shape.Area);
}

double totalPerimeter = 0;
foreach (Shape shape in shapes)
{
    totalPerimeter += shape.GetPerimeter();
}
Console.WriteLine($"Total perimeter: {totalPerimeter} inches ");



Console.WriteLine("------ex 4----------");
Manager manager = new Manager("John Doe", 35, 50000, Departament.IT);
Developer developer=new Developer ("Jane Smith", 28, 30000, new List<string> { "C#", "JavaScript", "C++"}, true);
Console.WriteLine($"Bonus manager: {manager.CalculateBonus()}");
Console.WriteLine($"Bonus developer: {developer.CalculateBonus()}");
Console.WriteLine($"Info manager: {manager.GetContactInfo()}");
Console.WriteLine();

Console.WriteLine("------ex5------");
BankAccount1 account1 = new BankAccount1("123456789", "Ion Popescu", 1000);
BankAccount1 account2 = new BankAccount1("654321", "Jane Smith", 2000);

account1.Deposit(500);
account2.Withdraw(1000);

Console.WriteLine($"Balance account 1: {account1.Balance}");
Console.WriteLine($"Balance account 2: {account2.Balance}");

Console.WriteLine(account1.GetInterest());
Console.WriteLine(account2.GetInterest());
Console.WriteLine(Bank.NumAccounts);

Console.WriteLine();

Console.WriteLine("-----ex6-----");
Ishape circle = new Circle2(5);
Ishape rectangle = new Rectangle2(10, 5, "green");

Console.WriteLine($"Area of circle: {circle.CalculateArea()}");
Console.WriteLine($"Area of rectangle: {rectangle.CalculateArea()}");

Console.WriteLine(circle.CalculateArea("square feet"));
Console.WriteLine(rectangle.CalculateArea("square meters"));

Icolor circleColor = (Icolor)circle;
circleColor.Color = "Red";

Icolor rectangleColor = (Icolor)rectangle;
rectangleColor.Color = "Violet";
Console.WriteLine($"Color of circle: {circleColor.Color}");
Console.WriteLine($"Color of rectangle: {rectangleColor.Color}");

Console.WriteLine();
Console.WriteLine("----ex7-----");

HotelManagerr.DisplayAvailableRooms();
Guest guest1 = new Guest("Ion Popica", "123-456-789");
Guest guest2 = new Guest("Ioana Popica", "034-456-777");
guest1.BookRoom(2);
guest1.GenerateBill(2, 3);
guest1.CheckOut(2);

guest2.BookRoom(5);
guest2.GenerateBill(5, 2);
guest2.CheckOut(5);














