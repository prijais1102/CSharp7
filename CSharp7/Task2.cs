using System;
using System.IO;

class Task2
{
    static void Main()
    {
        bool condition = true;
        string filePath = "C:\\Users\\PriyaJaiswal\\Desktop\\Demo\\demo1.txt.txt";
        while (condition)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create a new file");
            Console.WriteLine("2. Add contents to the file");
            Console.WriteLine("3. Append contents to the file");
            Console.WriteLine("4. Display contents one by one");
            Console.WriteLine("5. Display all contents together");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    FileInfo fileinfo = new FileInfo(filePath);
                    if (!fileinfo.Exists)
                    {
                        using (FileStream fs = File.Create(filePath)) { }
                        Console.WriteLine("File created.");
                    }
                    else
                    {
                        Console.WriteLine("File already exists");
                    }
                    break;
                case 2:
                    Console.Write("Enter content to add: ");
                    string contentToAdd = Console.ReadLine();
                    using (StreamWriter sw = new StreamWriter(filePath))
                    {
                        sw.WriteLine(contentToAdd);
                    }
                    Console.WriteLine("Content added.");
                    break;
                case 3:
                    Console.Write("Enter content to append: ");
                    string contentToAppend = Console.ReadLine();
                    using (StreamWriter sw = File.AppendText(filePath))
                    {
                        sw.WriteLine(contentToAppend);
                    }
                    Console.WriteLine("Content appended.");
                    break;
                case 4:
                    using (StreamReader sr = File.OpenText(filePath))
                    {
                        string s;
                        while ((s = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(s);
                        }
                    }
                    break;
                case 5:
                    string content = File.ReadAllText(filePath);
                    Console.WriteLine(content);
                    break;
                case 6:
                    condition = false;
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
                    break;
            }
        }
    }
}
