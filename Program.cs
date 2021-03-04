using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //01
            //DivisionNoHandling();

            //02
            //DivisionWithExceptionHandling();

            //03
            //DivisionWithExceptionHandlingMoreInfo();

            //04
            //DivisionWithExceptionHandlingThrow();

            //05
            //GeneratingException();

            //06
            HandlingRandomException();
            Console.ReadKey();
        }
        static int Division(int top, int bottom) => top / bottom;

        static void DivisionNoHandling()
        {
            Division(1,0);
            //call the division method with arguemment 1 and 0
            //this will terminate your application
        }
        static void DivisionWithExceptionHandling()
        {
            try
            {
                Division(1, 0);
            }
            catch { }
            //call the Division method with argument 1 and 0
            //You will catch the exception and do nothing
            //Your application should not crash
        }

        static void DivisionWithExceptionHandlingMoreInfo()
        {
            try
            {
                Division(1, 0);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            //call the division method with arguement 1 and 0
            //you will catch the exception and print the associated message
            //your application should not crash
        }
        static void DivisionWithExceptionHandlingThrow()
        {
            try
            {
                Division(1, 0);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                throw new Exception("Here I am throwing again");
            }
            //call the Division method with argument 1 and 0
            //You will catch the exception and print the associated message
            //You should create and throw a new exception
            //your application will crash
        }
        static void GeneratingException()
        {
            throw new Exception("Here's another new exception to throw");
            //you should create and throw a new exception
            //your application will crash
        }
        static void HandlingRandomException()
        {
            try
            {
                GeneratingRandomException();
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (OutOfMemoryException e)
            {
                Console.WriteLine(e.Message);
            }

            //You should call the method below and catch all the possible exceptions individually and display a sensible output
            //your application will not crash
        }
        static void GeneratingRandomException()
        {
            int exceptionType = new Random().Next() % 6;
            switch (exceptionType)
            {
                case 0:
                    throw new IndexOutOfRangeException();
                case 1:
                    throw new NullReferenceException();
                case 2:
                    throw new InvalidOperationException();
                case 3:
                    throw new ArithmeticException();
                case 4:
                    throw new FormatException();
                case 5:
                    throw new InvalidCastException();
                case 6:
                    throw new OutOfMemoryException();
            }
        }

    }
}
