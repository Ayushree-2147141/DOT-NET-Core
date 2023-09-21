namespace Day4
{
    //constructor and destructor
    //constructor : to create memory block

    //desctructor : destroys the object, when execution is finished
    class Sample
    {
        public int MyProperty { get; set; } //prop : creating property
        public Sample() //ctor
        {
            
        }
        ~Sample() { }
    }
    internal class Program
    {
        static void Main1(string[] args)
        {
            Sample s = new Sample();
        }
    }
}