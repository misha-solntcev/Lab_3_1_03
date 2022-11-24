using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 3. Даны целые положительные числа N и K. Используя только 
    операции сложения и вычитания, найти частное от деления 
    нацело N на K, а также остаток от этого деления.*/

namespace Lab_3_1_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = 10;
            int B = 3;

            int integer = 0;    // Целая часть числа
            int remainder = A;  // Остаток от деления
            while (remainder >= B)
            {
                integer++;
                remainder -= B;                
            }

            Console.WriteLine($"integer = {integer}, remainder = {remainder}");
            Console.ReadKey();                
        }
    }
}
