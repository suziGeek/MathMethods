﻿using System;

namespace MathMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me two numbers to perform some calculations!");
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            Add(num1, num2);
            Multiply(num1, num2);
            Divide(num1, num2);
            
        }

        public static int Add(int num1, int num2)
        {
            var sum = num1 + num2;
            Console.WriteLine($"Here are your answers! {num1} + {num2} = {sum}");
            return sum;
            
        }

        public static int Multiply(int num1, int num2)
        {
            var sum = num1*num2;
            Console.WriteLine($"Multiply {num1} * {num2} = {sum}");
            return sum;

        }

        public static int Divide(int num1, int num2)
        {
            var sum = num1/num2;
            Console.WriteLine($"Divide {num1} / {num2} = {sum}");
            return sum;

        }

    }
}
