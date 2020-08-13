﻿using System;
using System.Runtime.CompilerServices;

namespace Basic_Syntax
{
    class Program
    {
        static void Main(string[] args)
        {
            // this first hello world  program in C#
            Console.WriteLine("Hello World!");

            // Basic Synatax of C# Programming

            // 1- variable with different and basic data types
            int var1 = 10; // this variale data type in integer 
            string name = "Muhammad Hamza Farooq"; // this variable data type is string
            float num = 20.98F;  // this variable data type is float mean whole number
            double num1 = 3.999999D; // this varible data type is double this percsion point is vary long.
            char character = 'a';

            // 2- Type Casting 
            // There are two type of type Casting
            // a - Implicit type casting 
            // b - Explict type casting


            // Implicit Type  Casting (automatically) - converting a smaller type to a larger type size
            //char -> int -> long -> float -> double
            
            // ex : 1
            int a = 10;
            float b = a;

            // ex : 2

            char letter = 'a';
            int number = letter;
            long val = number;
            float val1 = val;
            double val2 = val1;
            bool con = true;

            // Explicit type casting (manually) - converting a larger type to a smaller size type
            //double -> float -> long -> int -> char

            // ex : 1
            float c = 30.3F;
            double d = (int) c;


            // ex : 2
            int n = 39;
            double num3 = 777.9898989D;
            float num4 = (float) n;
            long num5 = (long) num3;
            int num6 = (int)num4;
            char letter1 = (char) n;


            // Type Conversion Methods
            // In C# provide built in type conversion methods 
            // Such as Convert.ToBoolean, Convert.ToDouble, Convert.ToString, Convert.ToInt32 (int) and Convert.ToInt64 (long):

            int ingeter = 38;
            Console.WriteLine(Convert.ToDouble(ingeter));
            Console.WriteLine(Convert.ToString(ingeter));
            Console.WriteLine(Convert.ToChar(ingeter));
            Console.WriteLine(Convert.ToBoolean(ingeter));
            Console.WriteLine(Convert.ToInt64(ingeter));


            // 3 - User Input 
            // Console.WriteLine() is used to output (print) values. Now we will use Console.ReadLine() to get user input.
            Console.WriteLine("Please enter your  name ");
            string Name = Console.ReadLine();
            Console.WriteLine("Thats Good Job for " + Name);

            // ex : 1 
            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is " + age);


            //4 - Operators 

            // Arithematic Operator 
            int a1 = 39;
            int a2 = 78;

            int add = a1 + a2;
            int sub = a1 - a2;
            int multi = a1 * a2;
            float div = a1 / a2;
            int reminder = a1 % a2;
            int PostIncrement = a1++;
            int PreIncrement = ++a2;
            int PostDecrement = a1--;
            int PreDecrement = --a2;

            // 5 - Assignment Operator 

            int x = 5;   // =
             x += 6;   // x = x + 6
 
            int y = 0; 
            y -= 7;  // y = y - 7

            int z = 5;
            z *= 8; // z = z * 8

            double m = 2;
            m /= 8l; // m = m * 81 

            int s = 1;
            s %= 3; // s = s % 3 

            int f = 8;
            f &= 3;   // f = f & 3

            int j = 5;
            j |= 7;  // j = j | 7 

            int k = 04;
            k ^= 8;    //  k = k ^ 8 

            int l = 84;
            l >>= l;  // l = l >> 1 

            int q = 55;
            q <<= 8;   // q = q << 8



         

        }
    }
}