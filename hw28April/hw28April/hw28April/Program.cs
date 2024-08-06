using hw28April.Ex_1;
using hw28April.Ex_10;
using hw28April.Ex_2;
using hw28April.Ex_3;
using hw28April.Ex_4;
using hw28April.Ex_5;
using hw28April.Ex_6;
using hw28April.Ex_9;
using System.Threading.Channels;

try
{
    Console.WriteLine("Enter a date (yyyy-mm-dd):)");
    DateTime inputDate = DateTime.Parse(Console.ReadLine());

    if (inputDate < DateTime.Today)
    {
        throw new InvalidDateException("The entered date is in the past.");
    }
    else
    {
        Console.WriteLine("Entered date is in the future.");
    }
}
catch (FormatException)
{
    Console.WriteLine("Invalid date fromat. Please enter the date in yyyy-mm-dd format.");
}
catch (InvalidDateException ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine();
Console.WriteLine("----ex2---");

try
{
    Console.WriteLine("Enter names (separated bu commas):");
    string input = Console.ReadLine();
    string[] names = input.Split(',');
    foreach (string name in names)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new BlankNameException("one or more names are blank.");
        }
    }
    Console.WriteLine("All names are valid.");
}
catch (BlankNameException ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine();
Console.WriteLine("----ex 3------");
try
{
    NumberProcessor processor = new NumberProcessor();
    processor.ReadNumbers();
    processor.CalculateSumAndAverage();
}
catch (FormatException)
{
    Console.WriteLine("Error: Invalid input. Please enter valid numbers.");
}
catch (OverflowException)
{
    Console.WriteLine("Error: Sum of numbers is too large.");
}
catch(DivideByZeroException)
{
    Console.WriteLine("Error: Cannot calculate  average of an empty list.");
}

Console.WriteLine();
Console.WriteLine("----ex4-----");

FileHandler fileHandler=new FileHandler();
Console.WriteLine("Enter the name of a file:");
string fileName = Console.ReadLine();
fileHandler.HandleFile(fileName);

Console.WriteLine();
Console.WriteLine("----ex5-----");
DateTime now= DateTime.Now;
string fullDateString=now.ToFullDateString();
Console.WriteLine("Full date string :" + fullDateString);

Console.WriteLine("----ex6----");
int number = 5;
string binaryRepresentation = number.ToBinary();
Console.WriteLine("Binary representation of " + number+ ":" +binaryRepresentation);


Console.WriteLine();
Console.WriteLine("---ex 7-----");

List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int sumOfSquaresOfEvenNumbers = numbers
    .Where(x => x % 2== 0)
    .Select(x=> x*x)
    .Sum();
Console.WriteLine($"Sum of the squares of even numbers: {sumOfSquaresOfEvenNumbers}");


Console.WriteLine();
Console.WriteLine("----Ex 8----");

List<int> numberss = new List<int> { 1, 2, 3, 4, 5 };
List<int> squares=numberss.Select(x=>x*x).ToList();
Console.WriteLine("Original list: " + string.Join(", ", numbers));         // nu stiu sigur daca e ok asa..
Console.WriteLine("Original list: " + string.Join(", ", squares));


Console.WriteLine();
Console.WriteLine("-----ex.9-----");
var students = new List<Student>
{
    new Student {Name="Alice", Grade="A"},
    new Student {Name="Bob", Grade="B"},
    new Student {Name="Charlie", Grade="A"},
    new Student {Name="Dave", Grade="C"}
};

var studentsWithGradeA = students
    .Where(s => s.Grade == "A")
    .OrderByDescending(s => s.Name);

Console.WriteLine("Students with grade A (in descending order):");
foreach (var student in studentsWithGradeA)
{
    Console.WriteLine(student.Name);
}

Console.WriteLine();
Console.WriteLine("------ex10------");

var products = new List<Product>
{
    new Product { Name = "Product 1", Category = "Category 1", Price = 10 },
    new Product { Name = "Product 2", Category = "Category 2", Price = 20 },
    new Product { Name = "Product 3", Category = "Category 1", Price = 15 },
    new Product { Name = "Product 4", Category = "Category 3", Price = 5 },
    new Product { Name = "Product 5", Category = "Category 3", Price = 5 }

};
var distinctCategories=products
    .OrderBy(p => p.Price)
    .ThenBy(p => p.Name)
    .Select(p => p.Category)
    .Distinct()
    .ToList();

Console.WriteLine("Distinct categories sorted by price and then by name:");
foreach (var category in distinctCategories)
{
    Console.WriteLine(category);
}

Console.WriteLine("-----Ex 11----");

var categoryAveragePrices=products
    .GroupBy (p => p.Category)
    .Select (g=> new {Category = g.Key, AveragePrice=g.Average(p=> p.Price)})
    .OrderByDescending (c => c.AveragePrice)
    .ToList();

Console.WriteLine("Categories sorted by average price in descending order:");
foreach (var category in categoryAveragePrices)
{
    Console.WriteLine($"Category: {category.Category}, Average price:{category.AveragePrice}");
}
    

