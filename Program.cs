//A program for the average of the even numbers between 20-40
//Required the loop for 1-50

using System;
using System.Diagnostics.CodeAnalysis;
namespace Average_of_Even
{
     class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            int Sum = 0;
            int count = 0;
            while (num <= 50)
            {
                if(num>=20&&num<=40)
                {
                    if(num%2==0 )
                    {
                        Sum = Sum + num;
                        count++;
                    }
                  
                }
                num++;
            }
            Console.WriteLine("The average is:" + (Sum / count));
        }
    }
}
