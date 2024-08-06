using hwBuildGenerics.Ex3;
using System.Net.Http;



Console.WriteLine("------Ex1-----");
//ex1.

List<int> intList = new List<int> { 1, 2, 3, 4, 5 };
List<string> stringList = new List<string> { "cat", "dog", "apple", "cherry" };

ReverseList(intList);
ReverseList(stringList);

Console.WriteLine("Lista de int-uri inversată:");
intList.ForEach(i => Console.Write(i + " "));
Console.WriteLine();

Console.WriteLine("Lista de string-uri inversată:");
stringList.ForEach(s => Console.Write(s + " "));
Console.WriteLine();

static void ReverseList<T>(List<T> list)
{
    int count = list.Count;
    for (int i = 0; i < count / 2; i++)
    {
        T temp = list[i];
        list[i] = list[count - i - 1];
        list[count - i - 1] = temp;
    }
}

Console.WriteLine("-----ex.2-----");
//ex.2

List<int> intList2 = new List<int> { 1, 2, 3, 4, 5 };
List<string> stringList2 = new List<string> { "cat", "dog", "apple", "cherry" };

ApplyAction(intList2, i => Console.WriteLine($"Int element: {i}"));
ApplyAction(stringList2, s => Console.WriteLine($"String element: {s}"));

static void ApplyAction<T>(List<T> list, Action<T> action)
{
    foreach (var item in list)
    {
        action(item);
    }
}


Console.WriteLine("-----Ex.3------");

GenericQueue<int> intQueue = new GenericQueue<int>();
intQueue.Enqueue(1);
intQueue.Enqueue(2);
intQueue.Enqueue(3);

Console.WriteLine("Elementul din fața cozii: " + intQueue.Peek());
Console.WriteLine("Scoatem din coadă: " + intQueue.Dequeue());
Console.WriteLine("Elementul din fața cozii după dequeue: " + intQueue.Peek());
Console.WriteLine("Coada este goală? " + intQueue.IsEmpty());

GenericQueue<string> stringQueue = new GenericQueue<string>();
stringQueue.Enqueue("apple");
stringQueue.Enqueue("banana");
stringQueue.Enqueue("cherry");

Console.WriteLine("Elementul din fata cozii: " + stringQueue.Peek());
Console.WriteLine("Scoatem din coada: " + stringQueue.Dequeue());
Console.WriteLine("Elementul din fata cozii dupa dequeue: " + stringQueue.Peek());
Console.WriteLine("Coada este goala? " + stringQueue.IsEmpty());



Console.WriteLine("------Ex4-------");

static async Task Main(string[] args)
{
    List<string> urls = new List<string>
        {
            "https://www.example.com",
            "https://www.example.org",
            "https://www.example.net"
        };

    try
    {
        string firstResponse = await FetchFirstUrlContentAsync(urls);
        Console.WriteLine("Content of the first URL that responded:");
        Console.WriteLine(firstResponse);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"An error occured: {ex.Message}");
    }
}

static async Task<string> FetchFirstUrlContentAsync(List<string> urls)
{
    using HttpClient client = new HttpClient();
    var tasks = new List<Task<string>>();

    foreach (var url in urls)
    {
        tasks.Add(FetchUrlContentAsync(client, url));
    }

    Task<string> firstCompletedTask = await Task.WhenAny(tasks);
    return await firstCompletedTask;
}

static async Task<string> FetchUrlContentAsync(HttpClient client, string url)
{
    HttpResponseMessage response = await client.GetAsync(url);
    response.EnsureSuccessStatusCode();
    return await response.Content.ReadAsStringAsync();
}







