using System;  
using System.IO;  
public class StreamWriterExample  
{  
    public static void Main(string[] args)  
    {  
        string path=@"D:\C# codes\File Handling\output.txt";
        FileStream f = new FileStream(path, FileMode.OpenOrCreate);  
        StreamReader s = new StreamReader(f);  
        //   string? line =s.ReadLine();
         string? line = "";  
         while ((line = s.ReadLine()) != null){
        Console.WriteLine(line);}
        
        
        
        File.SetLastAccessTime(path, DateTime.Now);
        DateTime dt=File.GetLastAccessTime(path);
        dt=File.GetLastAccessTime(path);
        Console.WriteLine("The last access time for this file {0}",dt);
        
        
        
        
        
  
        // s.WriteLine("c# file handling concepts");  
        s.Close();  
        f.Close();  
    //  Console.WriteLine("File created successfully...");  
    /*string path=@"D:\C# codes\File Handling\output.txt";
    if(!File.Exists(path)){
        File.Create(path);
    }
    File.SetLastAccessTime(path,new DateTime(2023, 5, 6));
    DateTime dt=File.GetLastAccessTime(path);
    Console.WriteLine("The last access time {0}",dt);
    File.SetLastAccessTime(path, DateTime.Now);
    dt=File.GetLastAccessTime(path);
    Console.WriteLine("The last access time for this file {0}",dt);*/

    }  
}  