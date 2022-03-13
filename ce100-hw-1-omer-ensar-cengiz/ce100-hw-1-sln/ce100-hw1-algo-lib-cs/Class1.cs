using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ce100_hw1_algo_lib_cs
{
    public class Class1
    {
        /**
        * @file ce100_hw1_algo_lib_cs
        * @author Omer Ensar Cengiz
        * @date 13 October 2022
        *
        * @brief <b> HW-1 Functions </b>
        *
        * HW-1 Sample Lib Functions
        *
        * @see http://bilgisayar.mmf.erdogan.edu.tr/en/
        *
        */

        //Insertion Sort

        /**
        *
        *	  @name   Insertion Sort 
        *
        *	  @brief Insertion Sort 
        *
        *	  Insertion sort is a simple sorting algorithm that creates the last sorted array of one element at a time.
        *
        *	  @param  [in] fiIndex [\b int]   Insertion Sort in the serie
        *
        *	  @retval [\b int] Insertion Sort
        **/

        public static void InsSort(int[] mass)
        {
            for (int i = 1; i < mass.Length; i++)
            {
                int cur = mass[i];
                int j = i;
                while (j > 0 && cur < mass[j - 1])
                {
                    mass[j] = mass[j - 1];
                    j--;
                }
                mass[j] = cur;
            }
        }


        //Selection Sort

        /**
        *
        *	  @name   Selection Sort 
        *
        *	  @brief Selection Sort 
        *
        *	  Selection sort is an in situ comparative sorting algorithm.
        *
        *	  @param  [in] fiIndex [\b int]   Selection Sort  in the serie
        *
        *	  @retval [\b int]Selection Sort 
        **/

        public static int[] SortArray(int[] numArray, int arrayLength)
        {
            int tempVar, smallestVal;
            for (int i = 0; i < arrayLength - 1; i++)
            {
                smallestVal = i;
                for (int j = i + 1; j < arrayLength; j++)
                {
                    if (numArray[j] < numArray[smallestVal])
                    {
                        smallestVal = j;
                    }
                }
                tempVar = numArray[smallestVal];
                numArray[smallestVal] = numArray[i];
                numArray[i] = tempVar;
            }
            return numArray;
        }

        //RECURSİVE-POWER

        /**
        *
        *	  @name   Recursive-POWER
        *
        *	  @brief Recursive-POWER
        *
        *	 The classic example of recursive programming involves computational factors. The factorial of a number is calculated as the product of all numbers up to 1 below that number.
        *
        *	  @param  [in] fiIndex [\b int]   Recursive-POWER in the serie
        *
        *	  @retval [\b int] Recursive-POWER
        **/

        public static int CalcuOfPower(int x, int y)
        {
            if (y == 0)
                return 1;
            else
                return x * CalcuOfPower(x, y - 1);
        }

        //Naive Power

        /**
        *
        *	  @name   Naive Power 
        *
        *	  @brief Naive Power
        *
        *	  .
        *
        *	  @param  [in] fiIndex [\b int]   Naive Power in the serie
        *
        *	  @retval [\b int] Naive Power
        **/

        public static int Naivepower(int x, int y)
        {
            int pow = 1;

            for (int i = 1; i <= y; i++)
            {
                pow = pow * x;
            }

            return pow;
        }







        //Binary Search Recursive

        /**
        *
        *	  @name   Binary Search Recursive
        *
        *	  @brief Binary Search Recursive
        *
        *	  Binary search is a recursive algorithm. The general approach is that we examine the middle element of the list. The value of the middle element determines whether the algorithm terminates (key found), repeats the left half of the list, or repeats the right half of the list.
        *	  @param  [in] fiIndex [\b int]   Binary Search Recursive in the serie
        *
        *	  @retval [\b int] Binary Search Recursive
        **/
        public static int BinarySearchRecursive(int[] inputArray, int min, int max, int key)
        {


            int mid = min + (max - min) / 2;

            if (key == inputArray[mid])
            {
                return mid;
            }
            else if (key < inputArray[mid])
            {
                return BinarySearchRecursive(inputArray, min, mid - 1, key);
            }
            else
            {
                return BinarySearchRecursive(inputArray, mid + 1, max, key);
            }

        }


        //Binary Search Iterative

        /**
        *
        *	  @name   Binary Search Iterative
        *
        *	  @brief Binary Search Iterative 
        *
        *	  Like all divide-and-conquer algorithms, binary search first splits a large array into two smaller subarrays and then runs the subarrays recursively (or recursively). But instead of working on both substrings, it discards one substring and continues with the second substring.
        *
        *	  @param  [in] fiIndex [\b int]   Binary Search Iterative in the serie
        *
        *	  @retval [\b int] Binary Search Iterative
        **/

        public static int BinarySearchIterative(int[] inputArray, int key)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid])
                {
                    return mid;
                }
                else if (key < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }


        //Recursive MergeSort

        /**
        *
        *	  @name   Recursive MergeSort 
        *
        *	  @brief Recursive MergeSort 
        *
        *	  The merge-sort algorithm recursively splits the array in half until it reaches the ground state of 1-element array.
        *
        *	  @param  [in] fiIndex [\b int]   Recursive MergeSort in the serie
        *
        *	  @retval [\b int] Recursive MergeSort
        **/

        public static int[] mergeSort(int[] array)
        {
            int[] left;
            int[] right;
            int[] result = new int[array.Length];
            //since this is a recursive algorithm, we need a base case.
            //keep away from infinite recursion and thus stack overflow
            if (array.Length <= 1)
                return array;
            //middle point of our array  
            int midPoint = array.Length / 2;
            //Will symbolize our ''left'' array
            left = new int[midPoint];

            //if array has an even number of elements, the left and right array will have the same number of 
            //elements
            if (array.Length % 2 == 0)
                right = new int[midPoint];
            //if array has an odd number of elements, the right array will have one more element than left
            else
                right = new int[midPoint + 1];
            //fill left array
            for (int i = 0; i < midPoint; i++)
                left[i] = array[i];
            //fill right array   
            int x = 0;
            //We start to our index from the middle point, as we have already filled the left array from 0 to 

            for (int i = midPoint; i < array.Length; i++)
            {
                right[x] = array[i];
                x++;
            }
            //Recursively sort the left array
            left = mergeSort(left);
            //Recursively sort the right array
            right = mergeSort(right);
            //Merge our two sorted arrays
            result = merge(left, right);
            return result;
        }

        //This method will be responsible for combining our two sorted arrays into one giant array
        public static int[] merge(int[] left, int[] right)
        {
            int resultLength = right.Length + left.Length;
            int[] result = new int[resultLength];
            //
            int indexLeft = 0, indexRight = 0, indexResult = 0;
            //while either array still has an element
            while (indexLeft < left.Length || indexRight < right.Length)
            {
                //if both arrays have elements  
                if (indexLeft < left.Length && indexRight < right.Length)
                {
                    //If item on left array is less than item on right array, add that item to the result array 
                    if (left[indexLeft] <= right[indexRight])
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }
                    // else the item in the right array wll be added to the results array
                    else
                    {
                        result[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }
                //if only the left array still has elements, add all its items to the results array
                else if (indexLeft < left.Length)
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }
                //if only the right array still has elements, add all its items to the results array
                else if (indexRight < right.Length)
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }
            }
            return result;

        }//Master Method

        /**
        *
        *	  @name   Master Method
        *
        *	  @brief Master Method
        *
        *	  The main method is a formula for solving iterative relationships like this: T(n) = aT(n/b) + f(n)
        *	  
        *	  @param  [in] fiIndex [\b int]   Master Method in the serie
        *
        *	  @retval [\b int] Master Method
        **/

        public static string MasterMethod(int param, Func<int, string> function)
        {
            return function(param);
        }
        // Call via:
        string result = MasterMethod(2, a =>
        {
            if (a == 1)
            {
                return "if";
            }
            else
            {
                return "else";
            }
        });
    }
}
