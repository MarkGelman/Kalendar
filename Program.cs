using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalendar
{
    class Program
    {
        static void Main(string[] args)
        {
                string[] str = Console.ReadLine().Split('.');

                int year = int.Parse(str[0]);
                int month = int.Parse(str[1]);
                DateTime data = new DateTime(year, month, 1);
                Console.WriteLine("Mon Tue Wed Thu Fri Sat Sun");
                int days = DateTime.DaysInMonth(year, month);
                int day = (int)data.DayOfWeek;
                if (year == 1752 && month == 09)
                {
                    Console.WriteLine("      1   2  14  15  16  17");
                    Console.WriteLine(" 18  19  20  21  22  23  24");
                    Console.WriteLine(" 25  26  27  28  29  30");
                }
                else
                {
                    if (day == 0) day = 7;
                    day--;
                    for (int i = 0; i < day; i++)
                    {
                        Console.Write("    ");
                    }
                    for (int i = 1; i <= days; i++)
                    {
                        int d = (day + i - 1) % 7;
                        if (d < 6 && i != days)
                            Console.Write("{0,3} ", i);
                        else
                            Console.WriteLine("{0,3}", i);
                    }
                }
           
        }
    }
}
