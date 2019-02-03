using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rough__4
{
    class Program
    {
        static void Main(string[] args)
        {
            int  n, m, freqori = 0, freqlost = 0, element_under_inspection, j = 0;
            int[] store = new int[10];

            Console.Write("Please Enter number of elements in the Lost List ");
            n = int.Parse(Console.ReadLine()); //Accepting the number of elements in the array
            int[] lost = new int[n]; // Declaring an array with the size of the given input from user

            for (int i = 0; i < n; i++) // Running the loop to accept the arrays from the user
            {
                Console.Write("element - {0} : ", i);
                lost[i] = int.Parse(Console.ReadLine()); // Parsing the accepted value because the user is in the form chracter
            }

            lost = Sort(lost);


            Console.Write("Please Enter number of elements in the Original List ");
            m = int.Parse(Console.ReadLine()); //Accepting the number of elements in the array
            int[] original = new int[m]; // Declaring an array with the size of the given input from user

            for (int i = 0; i < m; i++) // Running the loop to accept the arrays from the user
            {
                Console.Write("element - {0} : ", i);
                original[i] = int.Parse(Console.ReadLine()); // Parsing the accepted value because the user is in the form chracter
            }


            original = Sort(original);

            for (int i = 0; i < original.Length; i++)
            {
                element_under_inspection = original[i];

                freqori = Frequency(element_under_inspection, original);
                freqlost = Frequency(element_under_inspection, lost);

                if (freqlost != freqori) 
                {
                    store[j] = element_under_inspection;
                    j++;

                }

            }

            store = RemoveDuplicates(store);

            for (int z = 0; z < store.Length - 1; z++)
            {

                {
                    Console.WriteLine("Final answer is   " + store[z]);
                }
                
            }
            Console.ReadKey(true);


        }// End of Main

        public static int[] Sort(int[] A)
        {
            int n = A.Length;
            for (int i = 0; i < n - 1; i++)                 //Using Bubble sort to sort the array
                for (int j = 0; j < n - i - 1; j++)
                    if (A[j] > A[j + 1])
                    {
                        // swap temp and arr[i] 
                        int temp = A[j];
                        A[j] = A[j + 1];
                        A[j + 1] = temp;
                    }
            return A;
                                 
        }// End of Sort Method

        public static int Frequency(int n1, int[] Arr)
        {
            int freq = 0;

            for (int i = 0; i < Arr.Length; i++)                // Counting the number of occurence of an element
            {
                if (n1 == Arr[i])
                {
                    freq++;
                }
            }
            return freq;

        } // End of Frequency Method


        private static int[] RemoveDuplicates(int[] a)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] != a[i + 1])
                {
                    result.Add(a[i]);
                }
            }

            result.Add(a[a.Length - 1]);
            return result.ToArray();

        }// End of Remove Duplicate method

    }// ENd of class
}// End of Namespace
