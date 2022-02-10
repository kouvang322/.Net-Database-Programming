using System;

namespace String_Interpolation_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Parse("2022-02-09 23:31");
            DateTime date2 = new DateTime(2022,02,09,23,31,00);


            Console.WriteLine($"1. {date2, 40: MMMM dd, yyyy}");
            Console.WriteLine($"2. {date2: yyyy.mm.dd}");
            Console.WriteLine($"3. Day {date2:dd} of {date2:MMMM},{date2:yyyy}");
            Console.WriteLine($"4. Year:{date2:yyyy},Month:{date2:MM},Day:{date2:dd}");
            Console.WriteLine($"5. {date2,10:dddd}");
            Console.WriteLine($"6. {date2,10:hh:mmtt}{date2,10:dddd}");
            Console.WriteLine($"7. h:{date2:hh},m:{date2:mm},s:{date2:ss}");
            Console.WriteLine($"8. {date2:yyyy.MM.dd.hh.mm.ss}");


            var pi = Math.PI;

            Console.WriteLine($"1. {pi:C} ");
            Console.WriteLine($"2. {pi, 10:n3} ");

        }
    }
}
