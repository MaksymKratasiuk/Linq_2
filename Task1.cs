using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_2
{
   
   class Task1 { 
        public static void task1() {
            int[] numbers = { 5, 12, 9, 3, 7, 15, 21, 8, 10, 6, 4 };

            // Розрахунок добутку елементів масиву
            int product = numbers.Aggregate((x, y) => x * y);
            Console.WriteLine("Добуток елементів масиву: " + product);

            // Розрахунок кількості елементів масиву
            int count = numbers.Count();
            Console.WriteLine("Кількість елементів масиву: " + count);

            // Розрахунок кількості елементів масиву, кратних 9
            int countDivisibleBy9 = numbers.Count(x => x % 9 == 0);
            Console.WriteLine("Кількість елементів масиву, кратних 9: " + countDivisibleBy9);

            // Розрахунок кількості елементів масиву, кратних 7 і більших, ніж 945
            int countDivisibleBy7GreaterThan945 = numbers.Count(x => x % 7 == 0 && x > 945);
            Console.WriteLine("Кількість елементів масиву, кратних 7 і більших, ніж 945: " + countDivisibleBy7GreaterThan945);

            // Розрахунок суми елементів масиву
            int sum = numbers.Sum();
            Console.WriteLine("Сума елементів масиву: " + sum);

            // Розрахунок суми парних елементів масиву
            int sumEven = numbers.Where(x => x % 2 == 0).Sum();
            Console.WriteLine("Сума парних елементів масиву: " + sumEven);

            // Знаходження мінімуму в масиві
            int min = numbers.Min();
            Console.WriteLine("Мінімум в масиві: " + min);

            // Знаходження максимуму в масиві
            int max = numbers.Max();
            Console.WriteLine("Максимум в масиві: " + max);

            // Знаходження середнього значення в масиві
            double average = numbers.Average();
            Console.WriteLine("Середнє значення в масиві: " + average);

            // Відображення трьох перших максимальних елементів
            Console.WriteLine("Три перші максимальні елементи:");
            Console.WriteLine(string.Join(" ", numbers.OrderByDescending(x => x).Take(3)));

            // Відображення трьох перших мінімальних елементів
            Console.WriteLine("Три перші мінімальні елементи:");
            Console.WriteLine(string.Join(" ", numbers.OrderBy(x => x).Take(3)));

           
            // Відображення статистики входження кожного числа до масиву
            var numberStatistics = numbers.GroupBy(x => x)
                                          .Select(group => new { Number = group.Key, Count = group.Count() });

            Console.WriteLine("Статистика входження кожного числа:");
            foreach (var item in numberStatistics)
            {
                Console.WriteLine($"{item.Number} - {item.Count} рази");
            }

            // Відображення статистики входження парних чисел у масив
            var evenNumberStatistics = numbers.Where(x => x % 2 == 0)
                                              .GroupBy(x => x)
                                              .Select(group => new { Number = group.Key, Count = group.Count() });

            Console.WriteLine("Статистика входження парних чисел:");
            foreach (var item in evenNumberStatistics)
            {
                Console.WriteLine($"{item.Number} - {item.Count} рази");
            }

            // Відображення статистики входження парних і непарних чисел до масиву
            var evenOddNumberStatistics = numbers.GroupBy(x => x % 2 == 0 ? "Парні" : "Непарні")
                                                 .Select(group => new { NumberType = group.Key, Count = group.Count() });

            Console.WriteLine("Статистика входження парних і непарних чисел:");
            foreach (var item in evenOddNumberStatistics)
            {
                Console.WriteLine($"{item.NumberType} - {item.Count} рази");
            }

        }
    }
}


