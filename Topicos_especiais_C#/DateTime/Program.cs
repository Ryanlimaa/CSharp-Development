using System;
using System.Globalization;

namespace Date_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;

            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);
            Console.WriteLine("-----------------------");
            //Exemplos de construtores
            DateTime d2 = new DateTime(2000, 8, 15);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);
            DateTime d4 = new DateTime(2000, 8, 15, 13, 5, 58, 275);

            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine("-----------------------");

            DateTime d5 = DateTime.Now;
            DateTime d6 = DateTime.UtcNow;
            DateTime d7 = DateTime.Today;

            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine("-----------------------");
            //Formatando com Parse
            DateTime d8 = DateTime.Parse("2000-08-15");
            DateTime d9 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d10 = DateTime.Parse("15/08/2000");
            DateTime d11 = DateTime.Parse("15/08/2000 13:05:58");

            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);
            Console.WriteLine(d11);
            Console.WriteLine("-----------------------");
            //Formatação personalizada
            DateTime d12 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd",CultureInfo.InvariantCulture);
            DateTime d13 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss",CultureInfo.InvariantCulture);

            Console.WriteLine(d12);
            Console.WriteLine(d13);
            Console.WriteLine("-----------------------");

            //Propriedades e Operações com DateTime
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);
            Console.WriteLine("-----------------------");

            DateTime s = new DateTime(2001, 8, 15, 13, 45, 58);
            string s1 = s.ToLongDateString();
            string s2 = s.ToLongTimeString();
            string s3 = s.ToShortDateString();
            string s4 = s.ToShortTimeString();
            string s5 = s.ToString();
            string s6 = s.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = s.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);
        }
    }
}