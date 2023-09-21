using System.IO;
namespace Day5
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            //StreamWriter sw = new StreamWriter("Test.txt");
            //WRITING INTO FILE
            string FilePath = "C:\\Users\\Administrator\\Desktop\\dotNET\\Day5\\Day5\\test.txt";
            StreamWriter sw = new StreamWriter(FilePath);
            Console.WriteLine("enter some value : ");
            string valueToWriteInFile = Console.ReadLine();

            sw.Write(valueToWriteInFile);
            
            sw.Flush();
            sw.Close();

            Console.WriteLine("Hello, World!");

            //reading using StreamReader
            StreamReader sr = new StreamReader(FilePath);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);    

            string output = sr.ReadLine();

            Console.WriteLine("Value from output : " + output);

            //READING FROM FILE using FILE in system.io
            string writeText = "welcome to writing part!";
            File.WriteAllText("C:\\Users\\Administrator\\Desktop\\dotNET\\Day5\\Day5\\demo1.txt",writeText);

            string readText  = File.ReadAllText("../../../demo1.txt");
            Console.WriteLine("Reading from demo1.txt \n "+readText);

        }
    }
}