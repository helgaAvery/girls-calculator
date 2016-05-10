using System;
using CalcGirl.Double;
using NUnit.Framework;

namespace CalcGirl.Tests.Double
{
     [TestFixture]
    public class CalculatorFactoryTests
    {
         [TestCase("add", typeof(Add))]
         [TestCase("minus", typeof(Minus))]
         [TestCase("multyply", typeof(Multyply))]
         [TestCase("divide", typeof(Divide))]
         [TestCase("XinY", typeof(XinY))]
         [TestCase("Log", typeof(Log))]
         [TestCase("SqrtY", typeof(SqrtY))]
         [TestCase("Ost", typeof(Ost))]
         [TestCase("Procent", typeof(Percent))]
         [TestCase("intDevide", typeof(IntDevide))]
         public void AddTest(string name, Type expected)
         {
             ICalculator calc = CalculatorFactory.CreateCalculator(name);
             Assert.IsInstanceOf(expected, calc);
         } 
    }
}