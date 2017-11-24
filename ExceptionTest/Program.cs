using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTest
{
    class Program
    {
        static void Main(string[] args)
        {

            //long a = long.MaxValue;
            //Console.WriteLine(a);
            //try
            //{
            //    checked
            //    {
            //        long b = a + 1;
            //        Console.WriteLine(b);
            //    }
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.StackTrace);
            //}
            try
            {
                throw new MyException("RRR");
            }
            catch(MyException ex)
            {
                Console.WriteLine(ex);
            }

            //try
            //{
            //    RunEx();
            //}
            //catch(NotImplementedException ex)
            //{
            //    Console.WriteLine("---" + ex.StackTrace);
            //    //throw ex;
            //}

            //Console.WriteLine("*********************************************");

            //try
            //{
            //    var a = 0;
            //    var o = 1 / a;
            //}
            //catch(DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.StackTrace);
            //    Console.WriteLine("*********************************************");
            //}
            //catch (ArithmeticException ex)
            //{
            //    Console.WriteLine(ex.StackTrace);
            //    Console.WriteLine("*********************************************");
            //}

            Console.ReadKey();   
        }
        static void RunEx()
        {
            var t = new TestA();
            t.TestEx();
        }
    }
}
