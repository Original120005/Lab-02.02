using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labwork_02._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            /*int[] mas = new int[10]; 
            Random rand = new Random(); 
            for(int i = 0; i < mas.Length; i++) {
                mas[i] = rand.Next(-10, 10);
                Console.WriteLine(mas[i]);
            }
            Console.WriteLine("\t");
            int chet = 0, nechet = 0, unik = 0;
            for(int i = 0; i < mas.Length;i++) {
                if (mas[i] % 2 == 0) {
                    chet++;
                }
                else if (mas[i] % 2 != 0) { 
                    nechet++;
                }
            }
            *//*int number = 0, count = 0;
            for(int i = 0; i < mas.Length; i++) {
                number = mas[i];
                for(int j = 0; j < mas.Length; j++) { 
                    if(number != mas[j]) { count++; }
                }
                if(count > 9) { unik++; }
            }*//*
            Console.WriteLine("\t");
            Console.WriteLine($"Четных: {chet}\tНечетных: {nechet}\tУникальных: {unik}");*/
           

            //задание 2
            /*int[] mas = new int[10];
            Random rand = new Random();
            for(int i = 0; i < mas.Length; i++) {
                mas[i] = rand.Next(0,100);
            }
            Console.WriteLine("Enter number form 0 to 100");
            string n = Console.ReadLine();
            int num = Convert.ToInt32(n);
            int count = 0;
            for(int i = 0; i < mas.Length; i++) { 
                if(num > mas[i]) {
                    count++;
                }
                Console.Write($"{mas[i]}  ");
            }
            Console.WriteLine($"\nTotal: {count}");*/
            

            //Задание 3
            int[] mas = new int[10];
            Random rand = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rand.Next(1, 10);
            }

            Console.WriteLine("Enter 3 number:");
            string n1 = Console.ReadLine();
            int num1 = Convert.ToInt32(n1);
            string n2 = Console.ReadLine();
            int num2 = Convert.ToInt32(n2);
            string n3 = Console.ReadLine();
            int num3 = Convert.ToInt32(n3);

            Console.WriteLine("\n");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write($"{mas[i]}  ");
            }

            int result = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (num1 == mas[i])
                {
                    if (num2 == mas[i + 1])
                    {
                        if (num3 == mas[i + 2])
                        {
                            result++;
                        }
                    }
                }
            }
            Console.WriteLine($"Result = {result}");



        }
    }
}
