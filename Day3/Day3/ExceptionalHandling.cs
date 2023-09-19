namespace Day3
{
    internal class ExceptionHandling
    {
        public static void Main(string[] args)
        {
            try
            {
                int a = 1;
                int b = 0;
                //int c = a / b;

                int[] ar = new int[5];
                Console.WriteLine(ar[5]);


            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Division by 0");
            }
            catch(IndexOutOfRangeException ex1)
            {
                Console.WriteLine(ex1.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Some error occured");
            }

            finally
            {
                Console.WriteLine("I am finally block");
            }

            Console.ReadLine();
        }
    }
}
