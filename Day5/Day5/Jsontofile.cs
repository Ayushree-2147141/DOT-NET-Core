using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Day5
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void WriteToFile(Student s, string FilePath)
        {
            StreamWriter sw = new StreamWriter(FilePath);
            sw.WriteLine(JsonConvert.SerializeObject(s));
            sw.Flush();
            sw.Close();

        }

        public Student ReadFromFile(string FilePath)
        {
            StreamReader sr = new StreamReader(FilePath);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string op = sr.ReadLine();
            return JsonConvert.DeserializeObject<Student>(op);
        }
    }
    internal class Jsontofile
    {
        public static void Main(string[] args)
        {
            string FilePath = "C:\\Users\\Administrator\\Desktop\\dotNET\\Day5\\Day5\\jsonfile.txt";
            Student s = new Student(1, "ayushree");
            s.WriteToFile(s, FilePath);

            var str = s.ReadFromFile(FilePath);
            Console.WriteLine(str.Id);
            Console.WriteLine(str.Name);

        }
    }
}
