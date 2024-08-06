using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw28April.Ex_4
{
    public class FileHandler
    {
        public void HandleFile(string fileName)
        {
            while (true)
            {


                try
                {
                    if (!File.Exists(fileName))
                    {
                        Console.WriteLine("File does not exist.");
                        Console.WriteLine("Enter some text to write to the file:");
                        string text = Console.ReadLine();
                        File.WriteAllText(fileName, text);
                        Console.WriteLine("\nFile contents:");
                        Console.WriteLine(text);
                    }
                    else
                    {
                        string text = File.ReadAllText(fileName);
                        if (string.IsNullOrEmpty(text))
                        {
                            Console.WriteLine("File is empty.");
                            Console.WriteLine("Enter some text to write to the file:");
                            text = Console.ReadLine();
                            File.WriteAllText(fileName, text);
                            Console.WriteLine("\nFile contents:");
                            Console.WriteLine(text);
                        }
                        else
                        {
                            Console.WriteLine("\nFile contents:");
                            Console.WriteLine(text);
                        }

                    }
                    break;

                }
                catch (IOException e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }
            }
        }
    }
}