//ex1.Given an array of integer numbers, print the total of all the values that are even numbers ([1, 2, 3, 4, 5] -> total = 6)

using System.ComponentModel.Design;

int[] numbersArray = { 1, 2, 3, 4, 5 };
int total = 0;
foreach (int number in numbersArray)
{
    if (number % 2 == 0)
    {
        total += number;
    }
}
Console.WriteLine($"Total of even numbers:{total}");

//ex.2 Find if an array of integer numbers contains duplicates and display them if so ([1, 2, 3, 3, 4] -> 3).

int[] numbers = { 1, 2, 3, 3, 4 };
HashSet<int> uniqueNumbers = new HashSet<int>();
HashSet<int> duplicates = new HashSet<int>();
foreach (int number in numbers)
{
    if (!uniqueNumbers.Add(number))
    {
        duplicates.Add(number);
    }
}

if (duplicates.Count > 0)
{
    Console.WriteLine("Duplicate numbers:");
    foreach (int duplicate in duplicates)
    {
        Console.WriteLine(duplicate);
    }
}
else
{
    Console.WriteLine("No duplicates found!");
}

//ex3.Check if there are duplicates in a list of strings. If yes, remove the them and display the new list ({"a", "b", "b", "c", "c", "d"} -> { "a", "b", "c", "d"}).

List<string> strings = new List<string> { "a", "b", "b", "c", "c", "d" };
HashSet<string> uniqueStrings = new HashSet<string>();
List<string> result= new List<string>();
foreach (string s in strings)
{
    if (uniqueStrings.Add(s))
    {
        result.Add(s);
    }
}
    Console.WriteLine("Original list:");
    Console.WriteLine(string.Join(",", strings));
    Console.WriteLine("List with duplicates removed:");
    Console.WriteLine(string.Join(",", result));

//ex4. Write a program to count the frequency of each element in an array and display it ([1, 4, 5, 2, 1, 4, 3, 1, 2] -> 1 - 3 times, 4 - 2 times, 5 - one time, 2 - 2 times, 3 - one time).

Console.WriteLine();
int[] numb = { 1, 4, 5, 2, 1, 4, 3, 1, 2 };
Dictionary<int,int> frequencyMap = new Dictionary<int,int>();
foreach (int number in numb)
{
    if (frequencyMap.ContainsKey(number))
    {
        frequencyMap[number] ++;
    }
    else
    {
        frequencyMap[number]=1;
    }
}
foreach (var entry in  frequencyMap)
{
    Console.WriteLine($"{entry.Key} - {entry.Value} time{(entry.Value == 1 ? "" : "s")}");

}

//ex.5. Create a list that contains 10 names read from the user. Using while print the first 6 names of the list ({a, b, c, d, e, f, g, h, i, j} -> { a, b, c, d, e, f}).

Console.WriteLine();
List<string> names = new List<string>();
Console.WriteLine("Enter 10 names:");
int count = 0;
while (count<10)
{
    Console.WriteLine($"Enter name {count+1}:");
    string name=Console.ReadLine();
    names.Add(name);
    count++;
}
Console.WriteLine("The first 6 names are:");
int index = 0;
while (index<6)
{
    Console.WriteLine(names[index]);
    index++;
}

//EX.6.Read a list from the console and separate odd and even values into two different new lists ({3, 4, 5, 6, 7, 8} -> Odd list: {3, 5, 7}, Even list: {4, 6, 8}).
Console.WriteLine();
Console.WriteLine("Enter the list of numbers separated by commas:");
string input = Console.ReadLine();
string[] numberStrings = input.Split(',');

List<int> oddNumbers = new List<int>();
List<int> evenNumbers= new List<int>();
foreach (string numberString in numberStrings)
{
    if (int.TryParse(numberString, out int number))
    {
        if (number % 2== 0)
        {
            evenNumbers.Add(number);
        }
        else
        {
            oddNumbers.Add(number);
        }
    }
}
Console.WriteLine($"Odd list: {{{string.Join(", ", oddNumbers)}}}");
Console.WriteLine($"Even list: {{{string.Join(", ", evenNumbers)}}}");

//ex.7. Read numbers from the user until the input is 0. Use a do while loop.

Console.WriteLine();
int num;
Console.WriteLine("Enter a number(if you enter 0, program is stopped)");
do
{
    Console.Write("Enter a number:");
    num = Convert.ToInt32(Console.ReadLine());
    if (num != 0)
    {
        Console.WriteLine("The program did not close. Enter another number:");
    }
}
    while (num != 0);
{ 
    Console.WriteLine("You enetered 0. Program stopped");
}

//ex.8 Iterate from -1 to -123 and print all the numbers. Break the iteration when you find the first number that divides to 21. Use do while and break.

int anotherNum = -1;
do
{
    anotherNum--;
    Console.WriteLine("Current number:"+anotherNum);
    if (anotherNum%21==0)
        {
        Console.WriteLine("First number divisible by 21 found:"+ anotherNum);
        break;
    }
}
while (anotherNum >=-123);

//ex.9. Read 10 names from the user (use a while loop) and store them in a list. Display all the names from the list except for the ones that start with "a", "A", "b" or "B". Use continue.
Console.WriteLine();

List<string> namess =new List<string>();    
int countt = 0;
Console.WriteLine("Enter 10 names:");
while (countt < 10)
{
    string name = Console.ReadLine();
    namess.Add(name);
    countt++;
}
Console.WriteLine("Names excluding those starting with: 'a', 'A', 'b' or 'B', are:");
foreach (string name in namess)
{
    if (name.StartsWith("a", StringComparison.OrdinalIgnoreCase) ||
        name.StartsWith("b", StringComparison.OrdinalIgnoreCase))
    { 
            continue;
     }
        Console.WriteLine(name);
 }


//ex.10. Read two numbers, a and b, from the user and create a collection with all the numbers between a and b.
//Be sure to have the collection in ascending order (a to b if a < b, b to a if b < a).
//Print the collection elements and also print all numbers that divide by 3 starting from a to b.
//Use both for and foreach loops (a = 3, b = 15 => collection = 3, 4, 5, ..., 14, 15 & output => 3, 6, 9, 12, 15).
Console.WriteLine();

Console.Write("Enter first number:");
int a=int.Parse(Console.ReadLine());
Console.Write("Enter second number:");
int b=int.Parse(Console.ReadLine());

List<int> numberss = new List<int>();
if (a<b)
{
    for (int i = a; i <= b; i++)
    {
        numberss.Add(i); 
    }
}
else
{
    for (int i = a; i >= b; i--)
    {
        numberss.Add(i);
    }
}
Console.WriteLine("Colection elements:");
foreach (int numm  in numberss)
{
    Console.WriteLine(numm+ "");                     //sorry for the strange name of the variables, but I don't know how to name them anymore:))
}
Console.WriteLine();
Console.WriteLine("Numbers divisible by 3 from a to b:");
for (int i = a; i <= b; i++)
{
    if (i % 3 == 0)
    {
        Console.WriteLine(i + "");
    }
}

//ex.11.Given an unsorted array which might have a number in the majority (a number appears at least 50 % in the array), find and print the first majority number if it exists.
int [] arrayy = {3,2,3,4,3,6,1,3,3};
int candidate = arrayy[0];
int counttt = 1;
for (int i = 0; i < arrayy.Length; i++)
{
    if (arrayy[i] == candidate)
    {
        counttt++;
    }
    else
    {
        counttt--;
    }
}
counttt = 0;
foreach(int nummb in arrayy)
{
    if (nummb==candidate)
    {
        counttt++;
    }
}
if (counttt > arrayy.Length/2)
{
    Console.WriteLine("First majority number found:"+candidate);
}
else
{
    Console.WriteLine("No majority number found");
}

Console.WriteLine();

//ex.12 Write an algorithm to check if a number is a palindrome or not (it is the same read from both ends).
//Print "the number is palindrome" if so or "the number is not palindrome" otherwise.
//palindrome: 2002, 1991, 121, 909, 22
//not palindrome 1932 -> 2391, 1995 -> 5991

Console.WriteLine("enter a number:");
int numbeer=int.Parse(Console.ReadLine());
int originalNumber = numbeer;
int reverseNumber = 0;
int remainder;
while (numbeer>0)
{
    remainder = numbeer % 10;
    reverseNumber = reverseNumber * 10 + remainder;
    numbeer /= 10;
}
if (originalNumber==reverseNumber)
{
    Console.WriteLine("Number is palindrome");
}
else
{
    Console.WriteLine("Number is not palindrome");
}

//end :)
