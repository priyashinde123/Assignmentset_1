using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1---
            /*  int num1 = 5;
              int num2 = 6;
              Console.WriteLine($"num1 : {num1}    num2 : {num2}");
              int tmp;
              tmp = num1;
              num1=num2;
              num2 = tmp;
              Console.WriteLine("After swapping");
              Console.WriteLine($"num1 : {num1}    num2 : {num2}"); */

            //Q2
            /* int num1;
             int num2;
             int num3;  

             Console.WriteLine("enter 3 number to multiply");
             num1=Convert.ToInt32(Console.ReadLine());
             num2=Convert.ToInt32(Console.ReadLine());
             num3 = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine($"multiplication  is : {num1*num2*num3}"); */


            //Q3
            /* int num1;
             int num2;

             Console.WriteLine("enter the 2 numbers for operation");
             num1=Convert.ToInt32(Console.ReadLine());
             num2=Convert.ToInt32(Console.ReadLine());
             Console.WriteLine($"{num1}+{num2} ={num1 + num2}");
             Console.WriteLine($"{num1}-{num2} ={num1 - num2}");
             Console.WriteLine($"{num1}*{num2} ={num1 * num2}");
             Console.WriteLine($"{num1}/{num2} ={num1 / num2}");
             Console.WriteLine($"{num1}%{num2} ={num1 % num2}"); */

            //Q4
            /* int num;
             Console.WriteLine("enter the number");
             num=Convert.ToInt32((Console.ReadLine()));

             for(int i=0;i<=10;i++)
             {
                 Console.WriteLine($" {num}*{i} = {num * i}");
             } */

            //Q5
            /*Console.WriteLine("enter the 4 number to calculate avg");
            int num1=Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            int num4 = Convert.ToInt32(Console.ReadLine());
            float avg=(num1 + num2 + num3 + num4)/4;
            Console.WriteLine($" The average of {num1},{num2},{num3},{num4} is : {avg}"); */


            //Q6
            /*  Console.WriteLine("enter the digit");
              int num=Convert.ToInt32(Console.ReadLine());
              Console.WriteLine($"{num} {num} {num} {num}");
              Console.WriteLine($"{num}{num}{num}{num}");
              Console.WriteLine("{0} {1} {2} {3}",num,num,num,num);
             Console.WriteLine("{0}{1}{2}{3}", num, num, num, num);
            */



            //Q7
            /*  Console.WriteLine("enter the number");
              int num=Convert.ToInt32(Console.ReadLine());
              Console.WriteLine($"{num}\t{num}\t{num}\t{num}\n{num}\t\t\t{num}\n{num}\t\t\t{num}\n{num}\t\t\t{num}\n{num}\t{num}\t{num}\t{num}");
            */


            //Q8
            /*Console.WriteLine("enter the amount of celsius");
            float c=float.Parse(Console.ReadLine());
            float F = c * 9 / 5 + 32;
            int k = (int) (c + 273.15F);
            Console.WriteLine($"kelvin = {k} \n Fahrenheit = {F}"); */


            //Q9
            /* Console.WriteLine("enter 2 numbers num");
             int num1=Convert.ToInt32(Console.ReadLine());
             
              int num2=Convert.ToInt32(Console.ReadLine());

             if((0<num1 && 0 >num2) || (0 < num2 && 0 > num1))
             {
                 Console.WriteLine("True");
             }

             */

            //Q10
            /*Console.WriteLine("enter two numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            if(num1 > num2)
            {
                Console.WriteLine(2 * (num1 - num2));
            }
            else
                Console.WriteLine(num2-num2);

            */








            /* int num = 5;
             for(int i=0; i<5; i++)
             {
                 for(int j=0; j<4; j++)
                 {
                     if (i == 0 || i==4  || j==0 || j==3)
                     {
                         Console.Write("5 ");

                     }
                     Console.Write(" ");
                 }
                 Console.WriteLine();
             }

             */


           


        }
    }
}
