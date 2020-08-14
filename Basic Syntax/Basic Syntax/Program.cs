using System;
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

            // 5- Comparision Operators

            // equal to == 

            int w = 0;
            int r = 8;
            bool t = (w == r);
            bool t1 = (w != r);
            bool t2 = (w > r);
            bool t3 = (w < r);
            bool t4 = (w >= r);
            bool t5 = (w > r);

            // 6 - Logical Operator 

            // And &&
            int value1 = 8;
            float value2 = 0.00F;
            bool res = (value1>5) && (value2<8);

            // OR  ||
            bool res1 = (value1 > 5) || (value2 < 8);

            // NOT !
            bool res2 = !(value1 > 5);


            // 7 - C# Maths

            //Math.Max(x,y)
            // The Math.Max(x, y) method can be used to find the highest value of x and y:

            Math.Max(8, 99);

            //Math.Min(x, y)
            //The Math.Min(x, y) method can be used to find the lowest value of of x and y:


            Math.Min(888, 9);

            //  Math.Sqrt(x)
            // The Math.Sqrt(x) method returns the square root of x:

            Math.Sqrt(5);

            //   Math.Abs(x)
            //The Math.Abs(x) method returns the absolute(positive) value of x:

            Math.Abs(-8.999);

            //Math.Round()
            // Math.Round() rounds a number to the nearest whole number:

            Math.Round(2.09090888);

            // 7- String 
            // the are many method for sorting of string 

            // a - Length

            string country = "Pakistan ";
            int len = country.Length;
            Console.WriteLine(country + " word length is " + len);

            // b - ToUpper()
            Console.WriteLine(country.ToUpper() + " word length is " + len);

            // c - ToLower
            Console.WriteLine(country.ToLower() + " word length is " + len);

            // f -You can also use the string.Concat() method to concatenate two strings:

            string NAME = "Sufyan";
            string FatherName = "Khan";
            string FullName = string.Concat(NAME, FatherName);
            Console.WriteLine(FullName);

            //which substitutes values of variables into placeholders in a string. 
            //Note that you do not have to worry about spaces, like with concatenation:
            string firstName = "John";
            string lastName = "Doe";
            string fullname = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(fullname);


            // g - You can access the characters in a string by referring to its index number inside square brackets [].

            //   This example prints the first character in myString:

            string myString = "Hello";
            Console.WriteLine(myString[1]);

            // h - You can also find the index position of a specific character in a string, by using the IndexOf() method:
            Console.WriteLine(myString.IndexOf("l"));


            // j - Another useful method is Substring(), which extracts the characters from a string, 
            // starting from the specified character position/index, and returns a new string.
            //This method is often used together with IndexOf() to get the specific character position:

            // full name 
            string studentName = "Jazib Khan";

            // Location of K letter
            int charPos = studentName.IndexOf("K");

            //get last name for substring() method
            string StudentLastName = studentName.Substring(charPos);
            Console.WriteLine(StudentLastName);


            // k - The sequence \"  inserts a double quote in a string:
            string txt = "my naem is \"Hamza \" ";
            Console.WriteLine(txt);

            // l- The sequence \'  inserts a single quote in a string:
            string txt1 = "my naem is \'Hamza \' ";
            Console.WriteLine(txt1);

            // q - The sequence \\  inserts a single backslash in a string:
            string txt2 = "my naem is \\ Hamza  ";
            Console.WriteLine(txt2);





        }

    }
}
