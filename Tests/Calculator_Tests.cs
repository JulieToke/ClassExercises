using CodeExamples;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class Calculator_Tests
    {
        [TestMethod]
        public void TestSum()
        {
            var calculator = new Calculator();
            
            var result = calculator.Sum(1, 2);
            Assert.AreEqual(3, result);

            result = calculator.Sum(10, 12);
            Assert.AreEqual(22, result);
        }
        [TestMethod]
        public void TestSub()
        {
            var calculator = new Calculator();
            
            var result = calculator.Substracts(4, 1);
            Assert.AreEqual(3, result);

            result = calculator.Substracts(34, 12);
            Assert.AreEqual(22, result);
        }
        [TestMethod]
        public void TestMul()
        {
            var calculator = new Calculator();

            var result = calculator.Multiply(4, 2);
            Assert.AreEqual(8, result);

            result = calculator.Multiply(3, 12);
            Assert.AreEqual(36, result);
        }
        [TestMethod]
        public void TestDiv()
        {
            var calculator = new Calculator();

            var result = calculator.Divide(4, 2);
            Assert.AreEqual(2, result);

            result = calculator.Divide(12, 4);
            Assert.AreEqual(3, result);
        }


        [TestMethod]
        public void Chain2_add()
        {
            var calculator = new Calculator();

            var result = calculator.Chain2("5+12");
            Assert.AreEqual(17, result);
        }
        [TestMethod]
        public void Chain2_sub()
        {
            var calculator = new Calculator();

            var result = calculator.Chain2("12-5");
            Assert.AreEqual(7, result);
        }
        
        [TestMethod]
        public void chain2_mult()
        {
            var calculator = new Calculator();

            var result = calculator.Chain2("5*12");
            Assert.AreEqual(60, result);
        } 
        [TestMethod]
        public void chain2_div()
        {
            var calculator = new Calculator();

            var result = calculator.Chain2("10/5");
            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void chainMany_1()
        {
            var calculator = new Calculator();

            var result = calculator.ChainMany("10/5+7*3-3");
            Assert.AreEqual(20, result);
        }
      }        
    }

