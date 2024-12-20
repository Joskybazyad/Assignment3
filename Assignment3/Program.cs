using System;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1:Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //Console.WriteLine("Please enter a number :");
            //int num = int.Parse(Console.ReadLine());

            //if (num < 1)
            //{
            //    Console.WriteLine("Please enter a number greater than or equal to 1.");
            //}
            //else
            //{
            //    for (int i = 1; i <= num; i++)
            //    {
            //        if (i < num)
            //        {
            //            Console.Write(i + ", ");
            //        }
            //        else
            //        {
            //            Console.Write(i);
            //        }
            //    }
            //}

            #endregion

            #region Q2:Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            //Console.WriteLine("Please enter a number :");
            //int num = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Multiplication table for {num}:");
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.Write(num * i);
            //    if (i < 12)
            //    {
            //        Console.Write(" ");
            //    }
            //}

            #endregion

            #region Q3:Write a program that allows to user to insert number then print all even numbers between 1 to this number
            //Console.WriteLine("Please enter a number :");
            //int num = int.Parse(Console.ReadLine());

            //if (num < 2)
            //{
            //    Console.WriteLine("No even numbers in the range.");
            //}
            //else
            //{
            //    Console.WriteLine($"Even numbers between 1 and {num}:");
            //    for (int i = 2; i <= num; i += 2)
            //    {
            //        Console.Write(i);
            //        if (i + 2 <= num)
            //        {
            //            Console.Write(" ");
            //        }
            //    }
            //}
            #endregion

            #region Q4: Write a program that takes two integers then prints the power.
            //Console.WriteLine("Please enter a number of base :");
            //int baseNumber = int.Parse(Console.ReadLine());

            //Console.Write("Enter the exponent: ");
            //int exponent = int.Parse(Console.ReadLine());
            //int result = 1;
            //for (int i = 1; i <= exponent; i++)
            //{
            //    result *= baseNumber;
            //}

            //Console.WriteLine($"{baseNumber}^{exponent} = {result}");
            #endregion

            #region Q5:Write a program to enter marks of five subjects and calculate total, average and percentage.
            //int subject1, subject2, subject3, subject4, subject5;

            //Console.WriteLine("Enter marks for each subject (out of 100):");
            //    Console.Write("Subject 1: ");
            //    subject1 = int.Parse(Console.ReadLine());

            //    Console.Write("Subject 2: ");
            //    subject2 = int.Parse(Console.ReadLine());

            //    Console.Write("Subject 3: ");
            //    subject3 = int.Parse(Console.ReadLine());

            //    Console.Write("Subject 4: ");
            //    subject4 = int.Parse(Console.ReadLine());

            //    Console.Write("Subject 5: ");
            //    subject5 = int.Parse(Console.ReadLine());
            //    if (subject1 < 0 || subject1 > 100 ||
            //        subject2 < 0 || subject2 > 100 ||
            //        subject3 < 0 || subject3 > 100 ||
            //        subject4 < 0 || subject4 > 100 ||
            //        subject5 < 0 || subject5 > 100)
            //    {
            //        Console.WriteLine("Marks should be between 0 and 100.");
            //        return;
            //    }
            //    int total = subject1 + subject2 + subject3 + subject4 + subject5;
            //    double average = total / 5.0;
            //    double percentage = (total / 500.0) * 100;
            //    Console.WriteLine($"Total Marks = {total}");
            //    Console.WriteLine($"Average Marks = {Math.Round(average, 2)}");
            //    Console.WriteLine($"Percentage = {Math.Round(percentage, 2)}");

            #endregion

            #region Q6:Write a program to input the month number and print the number of days in that month.
            //Console.Write("Enter the month number (1-12): ");
            //    int month = int.Parse(Console.ReadLine());
            //    int days;

            //    switch (month)
            //    {
            //        case 1:
            //        case 3:
            //        case 5:
            //        case 7:
            //        case 8:
            //        case 10:
            //        case 12:
            //            days = 31;
            //            break;
            //        case 4:
            //        case 6:
            //        case 9:
            //        case 11:
            //            days = 30;
            //            break;
            //        case 2:
            //            days = 28;
            //            break;
            //        default:
            //            Console.WriteLine("Invalid month number. Please enter a value between 1 and 12.");
            //            return;
            //    }

            //    Console.WriteLine($"Days in Month: {days}");
            #endregion

            #region Q7:Write a program to create a Simple Calculator.
            //double num1, num2, result;
            //string operation;

            //Console.WriteLine("Simple Calculator");
            //    Console.Write("Enter first number: ");
            //    num1 = double.Parse(Console.ReadLine());

            //    Console.Write("Enter second number: ");
            //    num2 = double.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter the operation (+, -, *, /): ");
            //    operation = Console.ReadLine();

            //    switch (operation)
            //    {
            //        case "+":
            //            result = num1 + num2;
            //            Console.WriteLine($"Result: {num1} + {num2} = {result}");
            //            break;
            //        case "-":
            //            result = num1 - num2;
            //            Console.WriteLine($"Result: {num1} - {num2} = {result}");
            //            break;
            //        case "*":
            //            result = num1 * num2;
            //            Console.WriteLine($"Result: {num1} * {num2} = {result}");
            //            break;
            //        case "/":
            //            if (num2 == 0)
            //            {
            //                Console.WriteLine("Error: Cannot divide by zero.");
            //            }
            //            else
            //            {
            //                result = num1 / num2;
            //                Console.WriteLine($"Result: {num1} / {num2} = {result}");
            //            }
            //            break;
            //        default:
            //            Console.WriteLine("Invalid operation. Please enter one of the following: +, -, *, /");
            //            break;
            //    }
            #endregion

            #region Q8:Write a program to allow the user to enter int and print the REVERSED of it.
            //Console.Write("Enter an integer: ");
            //    int number = int.Parse(Console.ReadLine());
            //    int reversed = 0;

            //    while (number != 0)
            //    {
            //        int digit = number % 10;
            //        reversed = reversed * 10 + digit;
            //        number /= 10;
            //    }

            //    Console.WriteLine($"Reversed Number: {reversed}");
            #endregion

            #region Q9:Write a program in C# Sharp to find prime numbers within a range of numbers.
            //Console.Write("Input starting number of range: ");
            //int start = int.Parse(Console.ReadLine());

            //Console.Write("Input ending number of range: ");
            //int end = int.Parse(Console.ReadLine());

            //Console.WriteLine("The prime numbers between {0} and {1} are:", start, end);

            //for (int num = start; num <= end; num++)
            //{
            //    if (num <= 1)
            //        continue;

            //    bool isPrime = true;
            //    for (int i = 2; i <= num / 2; i++)
            //    {
            //        if (num % i == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //    }

            //    if (isPrime)
            //    {
            //        Console.Write(num + " ");
            //    }
            //}
            #endregion

            #region Q10: Write a program in C# Sharp to convert a decimal number into binary without using an array.
            //Console.Write("Enter a number to convert: ");
            //int decimalNumber = int.Parse(Console.ReadLine());

            //string binaryRepresentation = "";

            //while (decimalNumber > 0)
            //{
            //    int remainder = decimalNumber % 2;
            //    binaryRepresentation = remainder + binaryRepresentation;
            //    decimalNumber /= 2;
            //}

            //Console.WriteLine($"The Binary of the number is {binaryRepresentation}");
            #endregion
        }
    }
}
