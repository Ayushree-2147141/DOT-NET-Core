namespace Day3
{
   
    //function overloading
    internal class Program
    {
        public void Sum()
        {
            Console.WriteLine("I am constructor");
        }
        public void Sum(int a)
        {
            Console.WriteLine("Single parameter : " + a);
        }
        public void Sum(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        public void Sum(string a , string b)
        {
            Console.WriteLine(a+b);
        }
        static void Main1(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Program p = new Program();
            p.Sum();
            p.Sum(1);
            p.Sum(1, 2);
            p.Sum("Hello ", "World !");
        }
    }
}