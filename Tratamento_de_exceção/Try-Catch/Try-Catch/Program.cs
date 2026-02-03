using System;
using System.Globalization;
using System.Collections.Generic;

namespace Try_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                double result = n1 / n2;

                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division by zero is not allowed");
            }

            //Ou...
            /*catch (Exception e)
            {
                Console.WriteLine("Error! " + e.Message);
            }*/

            catch (FormatException e)
            {
                Console.WriteLine("Format error! " + e.Message);
            }
        }
    }
}
