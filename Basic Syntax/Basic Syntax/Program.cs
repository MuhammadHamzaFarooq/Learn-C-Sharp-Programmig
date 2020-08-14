using System;
using System.Linq;
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

            // C# Conditions and If Statements
            // C# supports the usual logical conditions from mathematics:

            //Less than: a < b
            //Less than or equal to: a <= b
            //Greater than: a > b 
            //Greater than or equal to: a >= b
            //Equal to a == b
            //Not Equal to: a != b
            //You can use these conditions to perform different actions for different decisions.

            //C# has the following conditional statements:


            
            //Use if to specify a block of code to be executed, if a specified condition is true
            //Use else to specify a block of code to be executed, if the same condition is false
            //Use else if to specify a new condition to test, if the first condition is false
            //Use switch to specify many alternative blocks of code to be executed

            int time = 20;
            if (time < 18)
            {
                Console.WriteLine("Good morning ");
            }
            else if(time >20 ){
                Console.WriteLine("Good day ");
            }
            else
            {
                Console.WriteLine("Good evening ");
            }



            //   Short Hand If...Else(Ternary Operator)
            //There is also a short-hand if else, which is known as the
            //ternary operator because it consists of three operands. 
            //It can be used to replace multiple lines of code with a single line.
            //It is often used to replace simple if else statements:

            int Time = 30;
            string result = (Time > 77) ? "bad Day " : "Good Day" ;
            Console.WriteLine(result);



            //C# Switch Statements
            //Use the switch statement to select one of many code blocks to be executed.

            //This is how it works:

            // The switch expression is evaluated once
            //The value of the expression is compared with the values of each case
            //If there is a match, the associated block of code is executed
            //The break and default keywords will be described later in this chapter


            int day = 2;

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;

                case 2:
                    Console.WriteLine("Tuesday");
                    break;

                case 3 :
                    Console.WriteLine("Wedesday");
                    break;

                case 4:
                    Console.WriteLine("Tuesday");
                    break;

                case 5:
                    Console.WriteLine("Friday");
                    break;

                case 6:
                    Console.WriteLine("Saturday");
                    break;

                case 7:
                    Console.WriteLine("Sunday");
                    break;

               default:
                    Console.WriteLine("Looking forward to the Weekend.");
                    break;

            }

            // Loop

            //Loops can execute a block of code as long as a specified condition is reached.

            //Loops are handy because they save time, reduce errors, and they make code more readable.

            //C# While Loop

            //The while loop loops through a block of code as long as a specified condition is True:

            int i = 0;
            while(i < 8)
            {
                Console.WriteLine(i);
                i++;
            }


            //The Do/While Loop
            //The do/while loop is a variant of the while loop. This loop will execute the code block once, 
            //before checking if the condition is true, then it will repeat the loop as long as the condition is true.

            int values = 1;
            do
            {
                Console.WriteLine(values);
                values++;

            }
            while (values < 19);


            //C# for loop
            //When you know exactly how many times you want to loop through a block of code, use the for loop instead of a while loop:
            //Statement 1 is executed (one time) before the execution of the code block.Statement 1 is executed (one time) before the execution of the code block.
            //Statement 2 defines the condition for executing the code block.
            //Statement 3 is executed (every time) after the code block has been executed.

            for (a = 0; a< 9; a++)
            {
                Console.WriteLine(a);
                a++;
            }

            //This example will only print even values between 0 and 10:


            for (j =0; j<= 10; j= j + 2)
            {
                Console.WriteLine(j);
                j++;
            }

            //The foreach Loop
            //There is also a foreach loop, which is used exclusively to loop through elements in an array:
            string[] car = { "Volvo", "BMW", "Mazda", "Ford" };
            foreach(string rc in car)    // foreach is similar to for in =>   for i in 2..{ --body --}
            {
                Console.WriteLine(rc);
            }

            // C# Continue
            //The continue statement breaks one iteration (in the loop), if a specified condition occurs, and continues with the next iteration in the loop.

            for (k = 0; k<=10; k++)
            {
                if (k == 5)
                {
                    continue;

                }
                Console.WriteLine(k);


            }


            //C# Array
            int[] myNumber = { 1, 2, 33, 56, 7, 788, 99 };
            Console.WriteLine(myNumber.Length);


            //Array Methods
            //There are many array methods available, for example Sort(), which sorts an array alphabetically or in an ascending order:
            Array.Sort(myNumber);
            foreach (int p in myNumber)
            {
                Console.WriteLine(p);
            }


            //System.Linq Namespace
            //Other useful array methods, such as Min, Max, and Sum, can be found in the System.Linq namespace:
            Console.WriteLine(myNumber.Min());
            Console.WriteLine(myNumber.Max());
            Console.WriteLine(myNumber.Sum());

            //Other Ways to Create an Array

            //If you are familiar with C#, you might have seen arrays created with the new keyword,
            //and perhaps you have seen arrays with a specified size as well. In C#, there are different ways to create an array:

            // Create an array of four elements, and add values later
            string[] cars = new string[4];

            // Create an array of four elements and add values right away 
            string[] cars1 = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements without specifying the size 
            string[] cars2 = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements, omitting the new keyword, and without specifying the size
            string[] cars3 = { "Volvo", "BMW", "Ford", "Mazda" }; // this is best way for define and initilize the array




            //METHODS CONCEPT IN C#
            /*A method is defined with the name of the method, followed by parentheses (). 
             * C# provides some pre-defined methods, which you already are familiar with, 
             * such as Main(), but you can also create your own methods to perform certain actions:
             */

            /* MyMethod() is the name of the method
            static means that the method belongs to the Program class and not an object of the Program class.
            You will learn more about objects and how to access methods through objects later in this tutorial.
            void means that this method does not have a return value. You will learn more about return values later in this chapter
            */

            static void MyMethod()
            {
                // --  body -- 
                Console.WriteLine("Method");
                Console.WriteLine("Method");
                Console.WriteLine("Method");
                Console.WriteLine("Method");
            }


            // calling method 
            MyMethod();   // call one time 

            MyMethod();  // call second time


            //C# Method Parameters

            /*
             Parameters and Arguments
             
            Information can be passed to methods as parameter. Parameters act as variables inside the method.
            They are specified after the method name, inside the parentheses. You can add as many parameters as you want, just separate them with a comma.
            The following example has a method that takes a string called fname as parameter. When the method is called,
            we pass along a first name, which is used inside the method to print the full name:
             
             */

            static void  mymehtod(string fname)
            {
                Console.WriteLine(fname + "khan");
            }

            // calling mehtod
            mymehtod("hamza");
            mymehtod("ali");
            mymehtod("sufyan");




        }

    }
}
