using System;
using System.Collections.Generic;
using System.Text;

namespace CodeExamples
{
    public class Pyramids
    {
        /// <summary>
        /// For a given height - Write to the console output half a pyramid or a half triangle
        /// *                                                                                                    
        /// **                                                                                                 
        /// ***
        /// ****
        /// </summary>
        /// <param name="height"></param>
        /// 
        public void WriteHalfPyramid(int height)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }            
        }

        /// <summary>
        /// For a given height - Write to the console output a pyramid or a triangle
        ///    *                                                                                                    
        ///   ***                                                                                                 
        ///  *****
        /// ********
        /// </summary>
        /// <param name="height"></param>
        public void WritePyramid(int height)
        {
            for (int i = 0; i < height; i++)
            {
                int space = height / 2 - i;
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" ");
                }
                    for (int k = 1; k <= i; k++)
                    {
                        Console.Write("*");
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.Read();

        }

        /// <summary>
        /// For a given height - Write to the console output a numeric pyramid or a triangle
        ///    1                                                                                                    
        ///   222                                                                                                 
        ///  33333
        /// 4444444
        /// </summary>
        /// <param name="height"></param>
        public void WriteNumericPiramid(int height)
        {
        }
    }
}
