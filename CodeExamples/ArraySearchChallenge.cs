using System;
using System.Collections.Generic;
using System.Text;

namespace CodeExamples
{
    public class ArraySearchChallenge
    {
        /// <summary>
        /// For a given array with the numbers from 1..100
        /// The array is sorted
        /// An item has been removed.
        /// Find and Return that item
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public int FindMissingNumberInSortedArray(int[] items) {
            
        }


        /// <summary>
        /// For a given array with the numbers from 1..100
        /// The array is NOT sorted
        /// An item has been removed.
        /// Find and Return that item
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public int FindMissingNumberInArray(int[] items) {
            // result begins as cumulative sum of numbers 1 - 100
            var result = (Math.Pow(100, 2) + 100) / 2;
            for(i = 0; i < items.Length; i++)
            {
                   result =- items[i];
            }
            return result; 
        }


        /// <summary>
        /// For a given array with the numbers from x..y
        /// The array is NOT sorted
        /// An item has been removed.
        /// Find and Return that item
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public int FindMissingNumberInArrayUnKnownSizes(int[] items) { return 0; }

        static public void Main(String[] args) {
            // main method goes here
        }
    }
}
