using System;
using System.Collections.Generic;

namespace Lab1Part1_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Math Equation");// The title for the code

            Console.WriteLine("Please Enter One 3 Digit Number"); //Asking the user to perform the required action

            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Thanks! Please Add Another 3 Digit Number.");//Asking for another number

            int num2 = int.Parse(Console.ReadLine());


            List<int> listOfInts1 = new List<int>();//Creating a list seperating every digit in the first number into individual values
            while (num1 > 0)
            {
                listOfInts1.Add(num1 % 10);//% operator to ger the remainder which gives the individual digits
                num1 = num1 / 10;

            }

            List<int> listOfInts2 = new List<int>(); //Creating another list seperating every digit in the first number into individual values
            while (num2 > 0)
            {
                listOfInts2.Add(num2 % 10);//% operator to ger the remainder which gives the individual digits
                num2 = num2 / 10;

            }


            List<int> listOfInts3 = new List<int>();//This is the compiled list of the two above list


            for (int i = 0; i < listOfInts1.Count; i++)
            {
                listOfInts3.Add(listOfInts1[i] + listOfInts2[i]);//Starting the 3 seperate values at postion 0
         }

            for (int i = 0; i < listOfInts3.Count-1; i++)//Starting the 3rd list values at postion 0

            {

                if (listOfInts3[i] == listOfInts3[i + 1])//if else function to return a true if the list are equal to one another
                {
                    Console.WriteLine("True");
                }

            else//else function to return false if the list aren't equal to each other

            {
                    Console.WriteLine("False");
                }

            }

                
        }

    }

}