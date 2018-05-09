using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace popadanie_v_interval_znachenii_
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число от 0 до 100 чтобы определить интервал значений в который оно попадает,\nвсего 4-е интервала [0..14], [15..35], [36..50], [50..100]: ");
            string a = Console.ReadLine();
            int x = Convert.ToInt32(a);

            if(x>=0 && x<=14)
            {
                Console.WriteLine("Ваше число лежит в интервале [0..14]");
                Console.ReadKey();
            }

            if(x>=15 && x<=35)
            {
                Console.WriteLine("Ваше число лежит в интервале [15..35]");
                Console.ReadKey();
            }

            if(x>=36 && x<=50)
            {
                Console.WriteLine("Ваше число лежит в интервале [36..50]");
                Console.ReadKey();
            }

            if(x>=50 && x<=100)
            {
                Console.WriteLine("Ваше число лежит в интервале [50..100]");
                Console.ReadKey();
            }

            if(x<0 || x>100)
            {
                Console.WriteLine("Ваше чило либо меньше 0, либо больше 100");
                Console.ReadKey();
            }
        }        
    }
}
