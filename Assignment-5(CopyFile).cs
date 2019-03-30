using System;
using System.IO;

namespace FileEx
{
public class CopyFile
{
    public void copyFile(string file1, string file2)
    { 
        using(StreamReader reader = new StreamReader(file1))
        using (StreamWriter writer = new StreamWriter(file2))
        {
            string line = null;
            while ((line = reader.ReadLine()) != null)
                writer.WriteLine(line);
        }
    }
}
class MainClass
{
    public static void Main()
    {
        CopyFile cp = new CopyFile();
        string file1 = @"E:\Sem 6\.Net\File\1.txt";
        string file2 = @"E:\Sem 6\.Net\File\2.txt";
        cp.copyFile(file1,file2);
    }
}
}
