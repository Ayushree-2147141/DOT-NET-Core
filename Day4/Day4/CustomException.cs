using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    //CUSTOM EXCEPTIONS
    public class CustomExceptionError : Exception
    {
        //public CustomExceptionError()
        //{

//        }
        public CustomExceptionError(string message) : base(message) 
        { 

        }
    }
    internal class CustomException
    {
        public static void Main1(string[] args) 
        {
            try
            {
                //int a = 10;
                int b = 0;
                //int c = a / b;

                if(b == 0) { throw new CustomExceptionError("Hi! bugs in here! shuuu them away"); }

                //Console.WriteLine(c);
            }
            catch(CustomExceptionError e)
            //catch(Exception e) 
            {
                Console.WriteLine(e.Message);
            }
            finally { Console.WriteLine("Error resolved"); }

            Console.ReadKey();
        }
        
    }
}
