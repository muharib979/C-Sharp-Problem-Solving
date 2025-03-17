using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Linq;

class Program
{
   

    static void Main()
    {
        //1. Example: Get User Input

        //Console.Write("Enter your Name: ");
        //string name = Console.ReadLine();
        //Console.Write("enterYour age: ");
        //int age = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine($"Helle {name}, you are {age} your old ");


        // 2.Check Even or Odd Number

        //Console.Write("Enter a Number");
        //int num = Convert.ToInt32(Console.ReadLine());

        //if( num % 2 == 0)
        //{
        //    Console.WriteLine("Even Number");
        //}
        //else
        //{
        //    Console.WriteLine("Odd Number");
        //}

        // 3. Example: Simple Calculator

        //Console.Write("Enter a Number");

        //int num = Convert.ToInt32(Console.ReadLine());

        //switch (num)
        //{
        //    case 1:
        //        Console.WriteLine("One");
        //        break;
        //    case 2:
        //        Console.WriteLine("Two");
        //        break;

        //        default:
        //        Console.WriteLine("Other Number");
        //        break;
        //}

        //4.Print Numbers from 1 to 5


        //5.Print Numbers Until User Enters 0

        //int num;
        //Console.WriteLine("Enter a number");
        //num = Convert.ToInt32(Console.ReadLine());

        //while (num != 0)
        //{
        //    Console.WriteLine("You Entered: " + num);
        //    num = Convert.ToInt32(Console.ReadLine());
        //}
        //Console.WriteLine("Loop Ended");

        //6.Keep Asking for a Password Until Correct

        //string password;

        //do
        //{
        //    Console.Write("Entered A Password: ");
        //    password  = Console.ReadLine();
        //}
        //while (password != "123");
        //    Console.WriteLine("Granted");

        //7.Loop Through an Array

        //string[] names = { "12", "34", "21" };

        //foreach (string name in names)
        //{
        //    Console.WriteLine(name);
        //}

        //for(int i = 0; i <=10; i++)
        //{
        //    if(i == 5)
        //    {
        //        break;
        //    }
        //    Console.WriteLine(i);
        //}

        //for (int i = 0; i <=10; i++)
        //{
        //    if(i % 2 == 0)
        //    {
        //        continue;
        //    }
        //    Console.WriteLine(i);
        //}

        //Exercise 1: Print Even Numbers from 1 to 10

        //for (int i = 2 ; i <= 10; i +=2)
        //{
        //    Console.WriteLine(i);
        //}
        //Exercise 2: Keep Asking for Numbers Until a Negative Number is Entered


        //int num;
        //do
        //{
        //    Console.Write("Entered a number");
        //    num = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine( "You Entered :" +num);
        //}
        //while(num > = 0);
        //Console.WriteLine("Program Ended");

        //Exercise 3: Allow Only 3 Chances to Enter the Correct Password


        //string correctPassword = "123";
        //string password;
        //int attempts = 0;


        //do
        //{
        //    Console.Write("Enterd your password");
        //    password = Console.ReadLine();
        //        attempts++;

        //    if (password == correctPassword)
        //    {
        //        Console.WriteLine("granted");
        //        return;
        //    }

        //    else
        //    {
        //        Console.WriteLine("Wrong Password your attempts left: " + (3 - attempts));
        //    }
        //}

        //while (attempts < 3);
        //Console.WriteLine("Too many incorrect attempts. Access Denied.");

        //Print Squares of an Array of Numbers

        //    int[] numbers = { 2, 4, 6, 8, 10 };

        //foreach (int num in numbers) {
        //    Console.WriteLine($"Squre of {num}:  { num * num}");

        //}
        //Exercise 5: Print Odd Numbers from 1 to 10 using Continue


        //for (int i = 0; i <= 10; i++)
        //{
        //    if(i % 2 ==0)
        //    {
        //        continue;
        //    }
        //    Console.WriteLine(i);
        //}

        //List<int> numbers = new List<int>();

        //numbers.Add(5);
        //numbers.Add(15);
        //numbers.Add(25);
        //Console.WriteLine(numbers.Count);

        //int[] numbers = { 1, 2, 3, 4, 5 };
        //Console.WriteLine(numbers[2]);

        //int sum = 0;

        //foreach (int number in numbers)
        //{
        //    sum += number;
        //}

        //Console.WriteLine(sum);



        //int[] numbers = { 1, 2, 3, 4, 5 };
        //numbers[0] = 10;
        //Console.WriteLine("Updated Arrary:");

        //foreach (int i in numbers)
        //{
        //    Console.Write(i + " ");
        //}

        //Exercise 4: Sort an array and print elements in ascending order


        //int[] numbers = { 10, 20, 50, 40, 50 };

        //Array.Sort(numbers);

        //Console.WriteLine("Sorted array :");

        //foreach (int number in numbers)
        //{
        //    Console.Write(number + " ");
        //}

        //Exercise 6: Remove an element from a list and print the updated list

        //List<int> number = new List<int>() { 10, 20, 30, 50 };
        //number.Remove(20);
        //Console.WriteLine("Updated List: ");    
        //foreach (int i in number)
        //{
        //    Console.Write(i + " ");
        //}

        //Exercise 7: Ask the user to add names to a list and print the total count











    }
}
