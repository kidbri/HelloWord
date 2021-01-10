using System;
using System.Collections.Generic;

namespace HelloWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.LastName = "Vasa";
            
            //-------------------------------------------------

            Console.WriteLine("Введите несколько целых чисел:");

            List<int> number = new List<int>();

            while (number.Count < 3)
            {
                Console.Write($"Введите число {number.Count}: ");
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    number.Add(result);
                }   
            }

            Console.WriteLine("Вывод всей коллекции:");
            foreach (var item in number)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Сумма элементов коллекции:");
            int summa = 0;
            foreach (var item in number)
            {
                summa = summa + item;
            }
            Console.WriteLine(summa);

            Console.ReadLine();
        }
    }
}
