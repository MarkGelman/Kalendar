using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalendar
{
    class Program
    {
        /*Вам дан месяц конкретного года в формате yyyy.MM.
        Минимальная дата  - 1752.09
        Максимальная дата - 2999.12

        Составьте и выведите табличку этого месяца по дням по следующим правилам:

        1. В первой строке через пробел на английском языке с заглавной буквы
        перечислены первые три буквы дней недели, начиная с понедельника
        и заканчивая воскресеньем:
        Mon Tue Wed Thu Fri Sat Sun

        2. Вывести все дни месяца, последняя цифра каждого номера дня
        должна быть выровнена по правому краю соответствующего ей дня недели, 
        смотреть образец в открытом тесте.

        Начальные данные: строка формата yyyy.MM.
        Выходные данные: в первой строке должны быть записаны дни недели, как указано.
        В остальных строках по указанным правилам должны быть записаны числа месяца,
        выровненные по столбцам. 
        После последнего числа в строке пробелы выводить не нужно.

        Обратите внимание, что в 1752 году были удалены дни с 3 по 13 сентября. 
        Этот случай нужно обработать особо.*/

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
