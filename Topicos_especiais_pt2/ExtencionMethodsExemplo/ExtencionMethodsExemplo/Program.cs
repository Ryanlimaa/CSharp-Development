using ExtensionMethodsExemplo.Extensions;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExtensionMethodsExemplo
{
    public class Program
    {
        public static void Main()
        {
            DateTime dt = new DateTime(2025, 12, 31, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());

            string s1 = "Bom dia queridos estudantes!";
            Console.WriteLine(s1.Cut(11));
        }
    }
}   
