// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

Console.Clear();

using System;

namespace StringArrayProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод массива строк с клавиатуры
            Console.WriteLine("Введите элементы массива через запятую:");
            string inputString = Console.ReadLine();
            string[] inputArray = inputString.Split(',');

            // Фильтрация массива
            string[] filteredArray = FilterArray(inputArray);

            // Вывод отфильтрованного массива
            Console.WriteLine("\nОтфильтрованный массив:");
            foreach (string str in filteredArray)
            {
                Console.WriteLine(str.Trim()); // Убираем лишние пробелы
            }
        }
        static string[] FilterArray(string[] input)
        {
            int count = 0;
            foreach (string str in input)
            {
                if (str.Length <= 3)
                {
                    count++;
                }
            }
            
            string[] filtered = new string[count];
            int index = 0;
            foreach (string str in input)
            {
                if (str.Length <= 3)
                {
                    filtered[index++] = str;
                }
            }

            return filtered;
        }
    }
}