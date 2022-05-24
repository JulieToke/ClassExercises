﻿using System;

namespace CodeExamples
{
    public class Calculator
    {
        /// <summary>
        /// Sums Two Numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int Sum(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Substract a Number from a given number. Fist Number has to be bigger than the second number.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int Substracts(int a, int b)
        {
            return a - b;
        }

        /// <summary>
        /// Multiply two numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int Multiply(int a, int b) { return  a*b; }

        /// <summary>
        /// Divide a Number from a given number. First Number has to be bigger than the second number
        /// The result will be an integer number.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int Divide(int a, int b) 
        {
            //if (b <= 0)
                //throw new ArgumentException("I can't divide by 0 or a negative value");

            return a / b;
        }

        /// <summary>
        /// Perform Operations in the Chain of 2 elements
        /// 2+2 will return 4
        /// 4*2 will return 8
        /// ...
        /// </summary>
        /// <param name="operation"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int Chain2(string operation) 
        {
            var opSum = '+';
            var opSubs = '-';
            var opMult = '*';
            var opMDiv = '/';

            if (operation.Contains(opSum.ToString()))
            {
                var divideItems = operation.Split(opSum);
                var op1 = Int32.Parse(divideItems[0]);
                var op2 = Int32.Parse(divideItems[1]);

                return this.Sum(op1, op2);
            }
            if (operation.Contains(opSubs.ToString()))
            {
                var divideItems = operation.Split(opSubs);
                var op1 = Int32.Parse(divideItems[0]);
                var op2 = Int32.Parse(divideItems[1]);

                return this.Substracts(op1, op2);
            }
            if(operation.Contains(opMult.ToString()))
            {
                var divideItems = operation.Split(opMult);
                var op1 = Int32.Parse(divideItems[0]);
                var op2 = Int32.Parse(divideItems[1]);

                return this.Multiply(op1, op2);
            }
            if (operation.Contains(opMDiv.ToString()))
            {
                var divideItems = operation.Split(opMDiv);
                var op1 = Int32.Parse(divideItems[0]);
                var op2 = Int32.Parse(divideItems[1]);

                return this.Divide(op1, op2);
            }

            return 0;
        }

        /// <summary>
        /// Perform Operations in the Chain of many elements
        /// 2+2-1 will return 3
        /// 4*2-1 will return 7
        /// 10-1-2*2 will return 5
        /// </summary>
        /// <param name="operation"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int ChainMany(string operation) {
            // go through the string called operation perform each operation in pemdas 
            // 
            var opSum = '+';
            //var opSubs = '-';
            var opMult = '*';
            var opMDiv = '/';
            if (operation.Contains('-'.ToString()))
            {
                var divideItems = operation.Split('-');// [5*3+2/]= [0] [4]=[1]
                var op1 = divideItems[0];
                var op2 = divideItems[1];

                return this.Substracts(this.ChainMany(op1), this.ChainMany(op2));
            }
            if (operation.Contains(opSum.ToString()))
            {
                var divideItems = operation.Split(opSum);
                var op1 = divideItems[0];
                var op2 = divideItems[1];

                return this.Sum(this.ChainMany(op1), this.ChainMany(op2));
            }
            if (operation.Contains(opMDiv.ToString()))
            {
                var divideItems = operation.Split(opMDiv);
                var op1 = divideItems[0];
                var op2 = divideItems[1];

                return this.Divide(this.ChainMany(op1), this.ChainMany(op2));
            }
            if (operation.Contains(opMult.ToString()))
            {
                var divideItems = operation.Split(opMult);
                var op1 = divideItems[0];
                var op2 = divideItems[1];

                return this.Multiply(this.ChainMany(op1), this.ChainMany(op2));
            }            
            return Int32.Parse(operation);               
            
        }
    }
}
