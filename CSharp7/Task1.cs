using System;
using System.IO;

class Task1
{
    static void Main()
    {
       
        Directory.CreateDirectory("C:\\Users\\PriyaJaiswal\\Desktop\\Demo\\demo");

       
        Directory.CreateDirectory("C:\\Users\\PriyaJaiswal\\Desktop\\Demo\\demo1");
        Directory.CreateDirectory("C:\\Users\\PriyaJaiswal\\Desktop\\Demo\\demo2");

  
        File.Create("C:\\Users\\PriyaJaiswal\\Desktop\\Demo\\demo\\file1.txt").Close();
        new FileInfo("C:\\Users\\PriyaJaiswal\\Desktop\\Demo\\demo\\file2.txt").Create().Close();

        
        File.WriteAllText("C:\\Users\\PriyaJaiswal\\Desktop\\Demo\\demo\\file1.txt", "hello priya");
        File.WriteAllText("C:\\Users\\PriyaJaiswal\\Desktop\\Demo\\demo\\file2.txt", "hello priyaaa");

        
        File.Copy("C:\\Users\\PriyaJaiswal\\Desktop\\Demo\\demo\\file1.txt", "C:\\Users\\PriyaJaiswal\\Desktop\\Demo\\demo2\\file1.txt");

       
        var directories = Directory.GetDirectories("C:\\Users\\PriyaJaiswal\\Desktop\\Demo");
        var files = Directory.GetFiles("C:\\Users\\PriyaJaiswal\\Desktop\\Demo\\demo");

        Console.WriteLine("Directories:");
        foreach (var dir in directories)
        {
            Console.WriteLine(dir);
        }

        Console.WriteLine("Files:");
        foreach (var file in files)
        {
           Console.WriteLine(file);
        }

         
        foreach (var dir in directories)
        {
            Console.WriteLine($"{dir} was created on {Directory.GetCreationTime(dir)}");
        }

        foreach (var file in files)
        {
           Console.WriteLine($"{file} was created on {File.GetCreationTime(file)}");
        }


        foreach (var file in files)
        {
            File.Delete(file);
        }


        foreach (var dir in directories)
        {
            Directory.Delete(dir, true);
        }
    }
}

