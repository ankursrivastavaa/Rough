using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rough
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, SumLeft, SumRight, Flag = 0;
            Console.Write("Please Enter number of elements in the array ");
            n = int.Parse(Console.ReadLine()); //Accepting the number of elements in the array
            int[] arr = new int[n]; // Declaring an array with the size of the given input from user

            for (int i = 0; i < n; i++) // Running the loop to accept the arrays from the user
            {
                Console.Write("element - {0} : ", i);
                arr[i] = int.Parse(Console.ReadLine()); // Parsing the accepted value because the user is in the form chracter
            }

            if (n == 1)
            {
                Flag++;
            }

            for (int i = 0; i < n; i++)
            {
                SumLeft = Sum(0, i - 1, arr);                   // Calling Sum Function to calculate the values at each iteration
                SumRight = Sum(i + 1, arr.Length - 1, arr);

                if (SumLeft == SumRight)
                {
                    Console.WriteLine("Yes");
                    Flag++;
                    Console.ReadKey(true);
                    
                }                                       // End of IF
            }                                           // End of FOR

            if (Flag == 0)
            {
                Console.WriteLine("No");
                Console.ReadKey(true);
            }                                           // End of IF
            {

            }

        } // End of Main Method

        public static int Sum(int p,int q,int[]A)                       // Taking the values in the SUM function
        {
            int S = 0;
            for (int i = p; i <= q ; i++)                               // Running the loop based on the postion of i
            {
                S = S + A[i];
            }

            return S;
        }// end of SUM
    }// End of Program
}
