//Написать программу, которая задаёт массив из 8-ми элементов и выводит их на экран

using System;

namespace MassiveOnScreen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.Write("[ ");

            int[] numbers = { 2, 3, 4, 7, 9, 5, 12, 20 };

            foreach(int i in numbers)
            {
                Console.Write($"{i}, ");
            }
            Console.Write("]");
        }
    }
}
