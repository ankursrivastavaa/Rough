using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rough_Semi_merge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Function : Calculate the balanced sum");
            int[] arr = new int[] { 1, 2, 3 };
            string ans = balancedSums(arr);
            Console.WriteLine(ans);
            Console.WriteLine("----------------------------------------------------------------------------------");

            Console.WriteLine("Function : Identify the missing number or items");
            int[] arr1 = new int[] { 203, 204, 205, 206, 207, 208, 203, 204, 205, 206 };
            int[] brr = new int[] { 203, 204, 204, 205, 206, 207, 205, 208, 203, 206, 205, 206, 204 };
            int[] final = missingNumbers(arr1, brr);
            for (int z = 0; z < final.Length - 1; z++)
            {
                Console.WriteLine( final[z]);
            }
            Console.WriteLine("----------------------------------------------------------------------------------");

            Console.WriteLine("Function : Calculate Grades of student");
            int[] arr2 = new int[] { 73, 66, 38, 33 };
            int[] answer = gradingStudents(arr2);
            for (int z1 = 0; z1 < answer.Length; z1++)
            {
                Console.WriteLine(answer[z1]);
            }
            Console.WriteLine("----------------------------------------------------------------------------------");


            Console.WriteLine("Function : Calculate the Closest Numbers");
            int[] arr3 = new int[] { -20, -3916237, -357920, -3620601, 7374819, -7330761, 30, 6246457, -6461594, 266854, -520, -470 };
            int[] answer1 = closestNumbers(arr3);
            for (int z2 = 0; z2 < answer1.Length; z2++)
            {
                Console.Write(answer1[z2]);
                if (z2 < answer1.Length - 1)
                {
                    Console.Write(" ,");
                }
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------------------");

            Console.WriteLine("Function : Maxcount of toys");
            int[] p = new int[] { 1, 48, 2, 20, 20, 1 };
            int k = 50;
            int count = maximumToys(p, k);
            Console.WriteLine("The maxcount of toys is = " + count);
            Console.ReadKey(true);

        }// End of Main

        public static string balancedSums(int [] arr)
        {
            int n, SumLeft, SumRight, Flag = 0;
            string str = "";

            n = arr.Length;

            if (n == 1) 							            // Checking for the first Condition when there is only one element
            {
                Flag++;
            }

            for (int i = 0; i < n; i++)
            {
                SumLeft = Sum(0, i - 1, arr);                   // Calling Sum Function to calculate the values at each iteration
                SumRight = Sum(i + 1, arr.Length - 1, arr);

                if (SumLeft == SumRight)
                {
                    str = "Yes";
                    Flag++;

                }                                                // End of IF
            }                                                    // End of FOR

            if (Flag == 0)
            {
                str = "No";
            }                                                    // End of IF

            return str;


        } // End of Balanced Sum



        public static int Sum(int p, int q, int[] A)              // Taking the values in the SUM function
        {
            int S = 0;
            for (int i = p; i <= q; i++)                          // Running the loop based on the postion of i
            {
                S = S + A[i];
            }

            return S;
        }// end of SUM




        public static int[] missingNumbers(int [] lost, int[] original)
            {
        
            int freqori = 0, freqlost = 0, element_under_inspection, j = 0;
            int[] store = new int[10];

                lost = Sort(lost);                                          // Calling Sort function on Lost Array

                original = Sort(original);                                  // Calling Sort function on Lost Array, so the resulting array will be sorted 

            for (int i = 0; i<original.Length; i++)
                {
                        element_under_inspection = original[i];

                        freqori = Frequency(element_under_inspection, original);        // Calculating the frequncy of each element in both the arrays
                        freqlost = Frequency(element_under_inspection, lost);

                            if (freqlost != freqori)                                    // Comparing the calculated frequencies 
                            {
                                 store[j] = element_under_inspection;                   // Storing the missing elements in a array
                                 j++;

                            }

                }

            store = RemoveDuplicates(store);                                        // calling removeduplivates function to eliminate the duplicate elements 

            return store;

        }// End of missingNumbers





            public static int[] Sort(int[] A)
            {
            int n = A.Length;
            for (int i = 0; i < n - 1; i++)                         //Using Bubble sort to sort the array
                for (int j = 0; j < n - i - 1; j++)
                    if (A[j] > A[j + 1])
                        {
                                                                    // Using a temp variable to swap the values 
                            int temp = A[j];
                            A[j] = A[j + 1];
                            A[j + 1] = temp;
                    }
                return A;

            }// End of Sort Method

            public static int Frequency(int n1, int[] Arr)          // Passing the number whose frequncy needs to checked, and the array
            {
                int freq = 0;

                for (int i = 0; i < Arr.Length; i++)                // Counting the number of occurence of an element
                {
                    if (n1 == Arr[i])
                        {
                            freq++;                                 // Incrementing the value as the value of frequency increases
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


        public static int[] gradingStudents(int[] grades)
        {
            int[] marks = new int[grades.Length];                       

            for (int i = 0; i < grades.Length; i++)
            {
                int num = grades[i];                                // Storing the value of each number in a variable
                int roundup = num % 5;                              // Stroing the remainder of the number after taking mod by 5

                if (num < 38)                                       // Checking the for failing grades
                {
                    marks[i] = num;
                }

                else if (roundup >= 3 && num <=100)                 // Implementing condition where marks are to rounded up according to policy
                {
                    marks[i] = num + (5 - roundup);
                }

                else if (roundup < 3 && num <= 100)                 // Implementing the condition where marks will remain constant
                {
                    marks[i] = num;
                }
                else
                {
                    Console.WriteLine("Please enter the marks between 0-100");
                }
            }

            return marks;                                            // Returning the final array

        }// End of gradingStudents method



        public static int[] closestNumbers(int [] Arr)

        {
            int j = 0;
            int[] store = new int [Arr.Length + 10];

            Arr = Sort(Arr);                                                    // Sorting the array in acending order
            double oldmin = 1/.000000001 ;                                      // Initialing oldmin with a value which tends to positive infinity

            for (int i = 0; i < Arr.Length - 1; i++)
                {

                    double newmin = Arr[i] - Arr[i + 1];                        // taking the differnce between first element and second element

                    newmin = check(newmin);                                     // checking for the absolute difference

                    if (oldmin > newmin)
                    {

                        oldmin = newmin;
                        store[j] = Arr[i];                                     // Storing the value of the first element in the array if the newmin is smaller than oldmin
                        j++;                                                   
                        store[j] = Arr[i + 1];                                  //Storing the value of the second element
                        j++;                                                    // Incrementing the value of j by 1 to store the elements in the "store" array


                    }// end of IF

                    else if (oldmin == newmin)
                    {

                        store[j] = Arr[i];                                      // Same logic as above described
                        j++;
                        store[j] = Arr[i + 1];
                        j++;

                    }//  end of else if

                    else
                    {
                        //Do Nothing
                    }

                }// end of FOR 

                int[] final = new int[j];                               // This array will contain the final value that method return
                int[] recheck = new int[j];                             // This array is to recheck if all the pair of elements have same value of difference or not

                for (int i = 0; i < j; i++)
                {
                    final[i] = store[i];                                // Populating the values of store in array "final" and "check" from the "store" array
                    recheck[i] = store[i];

                }


                for (int i = 0; i < recheck.Length - 3; i = i + 2)                  // Hopping the value of i by 2, to pick the 1st, 3rd and so on numbers
                {

                    int diff1 = recheck[i] - recheck[i + 1];
                    int diff2 = recheck[i + 2] - recheck[i + 3];
                Console.WriteLine("diff1 = " + diff1);
                Console.WriteLine("diff2 = " + diff2);

                if (diff1 != diff2)                                                 // Checking if the difference bwteen first pair of elements is equal to second pair
                {
                    //closestNumbers(recheck);                                      // Tried to call the closest number function

                    Console.WriteLine("Needs to call once more the closestNumber function, but when it's called it's creating an infinite loop");
                }

                else
                    break;
                }
            return final;

        }// End of Method Closest Number


         static double check(double n)
        {
            if (n < 0)
            {
                n = n * -1;
                //Console.WriteLine("this is test");
            }
            return n;
        }

        static int maximumToys(int[] prices, int k)
        {
            Sort(prices);                                           // Sorting the array in order to check for the max price limit which Josh can afford
            int maxcount = 0, sum = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                if ((sum + prices[i]) < k)                          // Checking if the addition of the new number is still possible or not
                {
                    sum = sum + prices[i];                          // Adding all  the prices of the toys till now
                    maxcount++;                                     // Obtaining the count of the toys bought
                }
            }
            return maxcount;
        }// End of Maxcount Function



    }// End of Program
}// End of Namespace
