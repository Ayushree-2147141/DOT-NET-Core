namespace Day6
{
    class Test
    {
        public void Print()
        {
            Console.WriteLine("Hello from print");
        }
    }

    static class TestExtension
    {
        static public void PrintNew(this Test test)
        {
            Console.WriteLine("Print from print New");
        }
        static public void PrintNew()
        {
            Console.WriteLine("check point");
        }
    }

    internal class Program
    {
        static void Main1(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Test test = new Test();
            test.Print();
            test.PrintNew();
            //test.PrintNew();
            
        }
    }
}