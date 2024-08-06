using homeworkOOP;
using homeworkOOP.Exercise_0;
using homeworkOOP.Exercise_2;
using homeworkOOP.Exercise_3;
using homeworkOOP.Exercise_4;
using homeworkOOP.Exercise_5;
using homeworkOOP.Exercise_6;
using homeworkOOP.Exercise_7;
using homeworkOOP.Exercise_8;

Movie movie1 = new Movie("Titanic",1998,"Leonardo DiCaprio","drama");
Console.WriteLine("Movie details:");
movie1.PrintDetails();

Director director1=new Director("James Cameron",71);
Console.WriteLine("Director details:");
director1.PrintDetails();

Actors principalActors = new Actors("Kate Winslet", "Billy Zane", "Kathy Bates", "Frances Fisher", "Jonathan Hyde");
principalActors.PrintDetails();

Music music1 =new Music("My Heart will go on",1997, "Celine Dion");
music1.PrintDetails();


Console.WriteLine();
Crop crop = new Crop("Carrots");
Console.WriteLine("Crop details:");
crop.PrintDetails();

Console.WriteLine();
Farm LoveAnimals = new Farm("LoveAnimals", 1000, 267);
Console.WriteLine("Farm details:");
LoveAnimals.PrintDetails();
LoveAnimals.AddAnimals(24);
double density=LoveAnimals.CalculateDensity();
LoveAnimals.PrintDetailss();

Console.WriteLine();
Book book1 = new Book("Codul lui Da Vinci", "Dan Brown", 2003);
Console.WriteLine(book1.GetTitle());
Console.WriteLine(book1.GetAuthor());
Console.WriteLine(book1.GetYear());

Book book2 = new Book("Anna Karenina", "Leo Tolstoy", 1877);
Console.WriteLine(book2.GetTitle());
Console.WriteLine(book2.GetAuthor());
Console.WriteLine(book2.GetYear());


Console.WriteLine();
Product product = new Product("Apple", 4.50, 5);
Console.WriteLine(product.GetName());
Console.WriteLine(product.GetPrice());
Console.WriteLine(product.GetQuantity());

Console.WriteLine();
Product product2 = new Product("Orange", 3.45, 6);
Console.WriteLine(product2.GetName());
Console.WriteLine(product2.GetPrice());
Console.WriteLine(product2.GetQuantity());

Console.WriteLine();
Animal animal = new Animal("Rex", "Dog", "Labrador Retrevier", 2, "White", 43, true);
Console.WriteLine(animal.GetName());
Console.WriteLine(animal.GetSpecies());
Console.WriteLine(animal.GetBreed());
Console.WriteLine(animal.GetAge());
Console.WriteLine(animal.GetColor());
Console.WriteLine(animal.GetWeight());
Console.WriteLine(animal.IsSpayedOrNeutered());

animal.SetName("Miu");
animal.SetSpecies("Cat");
animal.SetBreed("Scotish");
animal.SetAge(3);
animal.SetColor("Gray");
animal.SetWeight(7);
animal.SetIsSpayedOrNeutered(false);
Console.WriteLine($"{animal.GetName()} {animal.GetSpecies()} {animal.GetBreed()}  {animal.GetAge()} {animal.GetColor()} {animal.GetWeight()} {animal.IsSpayedOrNeutered()}");

Console.WriteLine();
Calculator calculator = new Calculator();
Console.WriteLine(calculator.Add(2,3));
Console.WriteLine(calculator.Substract(5,2));
Console.WriteLine(calculator.Multiply(3,4));
Console.WriteLine(calculator.Divide(10,5));
Console.WriteLine(calculator.Power(2,3));
Console.WriteLine(calculator.SquareRoot(9));

Console.WriteLine("--------ex 7----------");
University myUniversity = new University("My University");
Student Mihaela = new Student("Mihaela", "Hariga", 123456, 3.9);
Student Angel = new Student("Angel", "Gatej", 343434, 3.9);
try
{
    Student invalidGpa = new Student("Roxana", "Dobrescu", 98674, 0);
}
catch (Exception ex)
{
    Console.WriteLine("Catch one exception:");
    Console.WriteLine(ex.Message);
}

myUniversity.AddStudent(Mihaela);
myUniversity.AddStudent(Angel);

Faculty Mary = new Faculty("Mary", "Jones", 342536, new List<string> { "Math", "Physics" });
Faculty Bob = new Faculty("Bob", "Smith", 232424, new List<string> { "English", "History" });

myUniversity.AddFaculty(Bob);
myUniversity.AddFaculty(Mary);

Console.WriteLine(myUniversity.GetStudentCount());
Console.WriteLine(myUniversity.GetFacultyCount());

Console.WriteLine("--------ex 8----------");
College myCollege = new College();
myCollege.Name = "Al.I.Cuza University";
myCollege.FoundedYear = 1860;
myCollege.City = "Iasi";
Console.WriteLine($"{myCollege.Name} {myCollege.City} {myCollege.FoundedYear}");

Professor professor1 = new Professor("Ioan Dumitru", "Physics Faculty", "Magnetic properties for materials", new List<string>{"Ioana","Mihai","Diana"}); 
Console.WriteLine($"Professor details: {professor1.Name}, {professor1.Faculty}, {professor1.Specialization}");
Console.WriteLine("Students who give their degree:");
foreach (string student in professor1.studentsWhoGiveTheirDegree)
{
    Console.WriteLine(student);
}

