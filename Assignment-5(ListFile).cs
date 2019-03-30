usingSystem;
usingSystem.Collections.Generic;
usingSystem.Linq;
usingSystem.Text;
usingSystem.IO;

namespace FileEx
{
class ListFile
{
public static void Main()
{
 string[] Directories=Directory.GetDirectories(@"E:\Sem-6");
 foreach(string dir in Directories)
 Console.WriteLine(dir);
 string[] files=Directory.GetFiles(@"E:\Sem-6");
 foreach(string file in files) 
 Console.WriteLine(file);

 Console.ReadKey();

}
}
}
