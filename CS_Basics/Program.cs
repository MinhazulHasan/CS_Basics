using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CS_Basics
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    internal partial class Program
    {
        static void Main(string[] args)
        {
            // 1. Print Hello World
            Console.WriteLine("Hello World!!!");

            // 2. Declare all type of primitive type and print them all
            byte byteNumber = 5;
            short shortNumber = 5555;
            int intNumber = 147570;
            long longNumber = 9999999999999;
            float floatNumber = 3.1416f;
            double doubleNumber = 3.1416;
            decimal decimalNumber = 3.1416m;
            char ch = 'S';
            bool isOK = true;
            Console.WriteLine($"{byteNumber} {shortNumber} {intNumber} {longNumber} {floatNumber} {doubleNumber} {decimalNumber} {ch} {isOK}");

            // 3. show exception if overflow occurs (Use “Checked” Keyword)
            byte byteValue = 255;
            checked
            {
                //byteValue++;
                Console.WriteLine(byteValue);
            }


            // 4. Show type conversion and print them. Use explicit and implicit conversion

            // string to int (vice-versa)
            string str1 = "555";
            int num1 = int.Parse(str1);
            Console.WriteLine("String to Int: " + num1);

            int num2 = 999;
            string str2 = num2.ToString();
            Console.WriteLine("Int to String: " + str2);

            // string to long (vice-versa)
            string str3 = "555";
            long num3 = long.Parse(str3);
            Console.WriteLine("String to Long: " + num3);

            long num4 = 999999999999;
            string str4 = num4.ToString();
            Console.WriteLine("Long to String: " + str4);

            // string to double (vice-versa)
            string str5 = "587325.2124521";
            double num5 = double.Parse(str5);
            Console.WriteLine("String to Double: " + num5);

            double num6 = 9565.654227734;
            string str6 = num6.ToString();
            Console.WriteLine("Double to String: " + str6);

            // string to float (vice-versa)
            string str7 = "2135.211";
            float num7 = float.Parse(str7);
            Console.WriteLine("String to Float: " + num7);

            float num8 = 21.6436f;
            string str8 = num8.ToString();
            Console.WriteLine("Float to String: " + str8);

            // string to bool (vice-versa)
            string str9 = "true";
            bool flag1 = bool.Parse(str9);
            Console.WriteLine("String to Bool: " + flag1);

            bool flag2 = true;
            string str10 = flag2.ToString();
            Console.WriteLine("Bool to String: " + str10);

            // int to long(vice - versa)
            int num9 = 6483673;
            long num10 = num9;  // Implicit Conversion
            Console.WriteLine("Int to Long: " + num10);

            long num11 = 224578;
            int num12 = (int) num11; // Explicit Conversion
            Console.WriteLine("Long to Int: " + num12);

            // char to ASCII int (vice versa)
            char ch1 = 'S';
            int num13 = (int) ch1;
            Console.WriteLine("Char to ASCII Int: " + num13);

            int num14 = 77;
            char ch2 = (char) num14;
            Console.WriteLine("ASCII Int to Char: " + ch2);

            // 5. Use Operators (+,-,*,/,%, |,^,&) and print results
            int a = 15, b = 4;
            Console.WriteLine($"a+b = {a + b} \t a-b = {a - b} \t a*b = {a * b} \t a//b = {a / b} \t a%b = {a % b} \t a|b = {a | b} \t a^b = {a ^ b} \t a&b = {a & b}");


            // 6. Use if,if else, else if
            int marks = 70;
            if (marks > 59)
                Console.WriteLine("1st Class");
            else if (marks > 39)
                Console.WriteLine("2nd Class");
            else
                Console.WriteLine("3rd Class");

            // 7. Use more operators like(&&, || ) inside conditional operators
            int hour = 10;
            if (hour > 0 && hour < 12)
                Console.WriteLine("It's Morning.");
            else if (hour >= 12 && hour < 18)
                Console.WriteLine("It's Afternoon");
            else
                Console.WriteLine("It's Evening");


            // 8. Use ternary logical operators
            bool isGoldCustomer = true;
            float price = isGoldCustomer ? 19.95f : 29.95f;
            Console.WriteLine(price);


            // 9. Use Different types of comments
            // This is a single line comment
            /*
                This is a
                multiline comments.
                It's use for documentaton in
                most of the cases.
            */


            // 10. For, While, Do while, Foreach, continue & break (print 1-100, skip at 95, break at 99)
            int i = 1;
            while (i <= 100)
            {
                if (i != 95 && i != 99)
                {
                    Console.Write(i + " ");
                    i++;
                }
                else
                {
                    if(i == 95)
                    {
                        i++;
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.Write("\n\n");

            for (i = 1; i <= 100; i++)
            {
                if (i == 95)
                    continue;
                if (i == 99)
                    break;
                else
                    Console.Write(i + " ");
            }
            Console.Write("\n\n");

            var name = "Minhazul Hasan";
            foreach (char c in name)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();


            // 11. Switch case 
            var season = Season.Autumn;
            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's Autumn and a beautiful season.");
                    break;

                case Season.Summar:
                    Console.WriteLine("It's Perfect to go to beach");
                    break;

                default:
                    Console.WriteLine("I don't understand the season");
                    break;
            }


            // 12. Declare classes and print object ( class should contain method and properties)
            Person sohan = new Person
            {
                firsrName = "Minhazul Hasan",
                lastName = "Sohan"
            };
            sohan.Introduce();

            // 13. Declare structure and print object (use method and properties)
            RGBcolor rgb = new RGBcolor
            {
                color1 = "Red",
                color2 = "Green",
                color3 = "Blue"
            };
            rgb.PrintColorName();


            // 14. Show that classes are reference type but primitive variable aren't
            var number = 1;
            Increment(number);
            Console.WriteLine("Number = " + number);

            var person = new Person() { Age = 1 };
            MakeOld(person);
            Console.WriteLine("Age = " + person.Age);

            Console.WriteLine("Here, number is primitive variable (integer) and in C# it's a value type so the value is unchanged after calling the funtion. On the other hand Classes in C# are reference type so after calling the function it increment the main value.");


            // 15. Declare arrays of size 15. Array type should be bool,char,int,long,double,string etc
            bool[] boolArray = new bool[15];
            char[] charArray = new char[15];
            int[] intArray = new int[15];
            long[] longArray = new long[15];
            double[] doubleArray = new double[15];
            string[] stringArray = new string[15];


            // 16. Insert dummy value to those arrays and print them. While printing skip index no 5 and print until index 10. (use for,while,foreach,break,continue)
            var random = new Random();
            for (i=0; i<intArray.Length; i++)
            {
                intArray[i] = random.Next(100, 500);
            }
            for (i = 0; i < intArray.Length; i++)
            {
                if (i == 5)
                    continue;
                if (i == 11)
                    break;
                else
                    Console.Write(intArray[i] + " ");
            }
            Console.WriteLine();


            // 17. Declare Enum. Convert a string to enum, int to enum, enum to string, enum to int
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            Console.WriteLine(method.ToString());

            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName, true);
            Console.WriteLine(shippingMethod);


            // 18. Declare a 2 class containing the same method. One method should be static. Now access the method from main class
            Console.WriteLine(Calculator.Multiplication(3, 2));


            // 19. Declare a list of int, string, double. Find out all list manipulation methods and implement them.
            var myList = new List<int>() { 1, 2, 3, 4 };
            myList.Add(5);
            myList.Add(6);

            foreach (var num in myList)
                Console.Write(num + " ");
            Console.WriteLine();

            myList.AddRange(new int[3] { 7, 8, 9 });

            foreach (var num in myList)
                Console.Write(num + " ");
            Console.WriteLine();

            Console.WriteLine("Index of 6 = " + myList.IndexOf(6));
            Console.WriteLine("Total Count = " + myList.Count);

            myList.Remove(9);
            myList.Remove(5);
            foreach (var num in myList)
                Console.Write(num + " ");
            Console.WriteLine();

            myList.Clear();
            Console.WriteLine("Total Count = " + myList.Count);



            // 20. Declare an array of int, string, double. Find out all array manipulation methods and implement them.
            int[] numbers = new int[] { 3, 1, 12, 6, 71, 8 };

            // Length
            Console.WriteLine("Length = " + numbers.Length);

            // IndexOF()
            int index = Array.IndexOf(numbers, 6);
            Console.WriteLine(index);

            // Clear()
            Array.Clear(numbers, 0, 2);
            foreach (var num in numbers)
                Console.Write(num + " ");
            Console.WriteLine();

            // Copy()
            int[] another = new int[3];
            Array.Copy(numbers, 2, another, 0, 3);
            foreach (var num in another)
                Console.Write(num + " ");
            Console.WriteLine();

            // Sort()
            Array.Sort(numbers);
            foreach (var num in numbers)
                Console.Write(num + " ");
            Console.WriteLine();

            // Reverse()
            Array.Reverse(numbers);
            foreach (var num in numbers)
                Console.Write(num + " ");
            Console.WriteLine();



            // 21. Declare datetime, timespan. Find all datetime manipulation methods.
            var datetime = new DateTime(2022, 8, 16);
            var now = DateTime.Now;
            Console.WriteLine("Now = " + now);
            Console.WriteLine("Now = " + now.ToString());
            Console.WriteLine("Now = " + now.ToString("yyyy-MM-dd"));
            Console.WriteLine("Now = " + now.ToString("yyyy-MM-dd HH:mm"));

            Console.WriteLine("Now Hour = " + now.Hour);
            Console.WriteLine("Now Minute = " + now.Minute);
            Console.WriteLine("Now Year = " + now.Year);
            

            var today = DateTime.Today;
            Console.WriteLine("Today = " + today);

            var tomorrow = now.AddDays(1);
            Console.WriteLine("Tomorrow = " + tomorrow);

            var yesterday = now.AddDays(-1);
            Console.WriteLine("Yesterday = " + yesterday);

            Console.WriteLine("Formatting: ");
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());


            var timeSpan = new TimeSpan(1, 2, 3);
            Console.WriteLine("To String = " + timeSpan.ToString());
            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration = " + duration);
            
            Console.WriteLine("Minutes = " + timeSpan.Minutes);
            Console.WriteLine("Total Minutes = " + timeSpan.TotalMinutes);
            
            Console.WriteLine("Add Example = " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Subtract Example = " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));


            // 22. Declare string and find all types of string manipulation methods.
            string myString1 = "Brain Station-23,";
            Console.WriteLine(myString1);
            Console.WriteLine(myString1.Length);

            string myString2 = " ASP dot NET";
            string joinString = string.Concat(myString1, myString2);
            Console.WriteLine("Join = " + joinString);

            string myString3 = "C# Programming";
            string myString4 = "C# Programming";
            string myString5 = "C++ Programming";

            Boolean result1 = myString3.Equals(myString4);
            Console.WriteLine("string myString3 and myString4 are equal? : " + result1);

            Boolean result2 = myString3.Equals(myString5);
            Console.WriteLine("string myString3 and myString5 are equal? : " + result2);

            string myName = "mInHazuL hasAN SOhan";
            Console.WriteLine(myName.ToLower());
            Console.WriteLine(myName.ToUpper());
            Console.WriteLine(myName.IndexOf('H'));


            // 23. Declare a string and change some character of the string (use StringBuilder)
            var company = new StringBuilder();
            company.Append("Brain Station-23");
            Console.WriteLine("Company = " + company);
            
            company.Replace("Brain Station", "BS");
            Console.WriteLine("Company = " + company);


            // 24. Find out all StringBuilder methods
            var builder = new StringBuilder();
            builder
                .Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10);
            Console.WriteLine(builder);

            builder.Replace('-', '+');
            Console.WriteLine(builder);

            builder.Remove(0, 5);
            Console.WriteLine(builder);

            builder.Insert(0, new string('*', 5));
            Console.WriteLine(builder);
            Console.WriteLine("First Character = " + builder[0]);

            Console.ReadLine();
        }


        public static void Increment(int number)
        {
            number += 10;
        }
        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}
