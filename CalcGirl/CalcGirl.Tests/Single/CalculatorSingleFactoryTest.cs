using System;
using CalcGirl.Double;
using CalcGirl.Single;
using NUnit.Framework;

namespace CalcGirl.Tests.Single
{
    [TestFixture]
    public class CalculatorSingleFactoryTest
    {
        [TestCase("Sin", typeof(Sin))]
        [TestCase("Cos", typeof(Cos))]
        [TestCase("Sqrt", typeof(Sqrt))]
        [TestCase("Tan", typeof(Tan))]
        [TestCase("Mod", typeof(Mod))]
        [TestCase("ATan", typeof(ATan))]
        [TestCase("Exp", typeof(Exp))]
        [TestCase("XinThree", typeof(XinThree))]
        [TestCase("Obr", typeof(Obr))]
        [TestCase("Log10", typeof(Log10))]
        [TestCase("Xinx", typeof(Xinx))]
        [TestCase("in10x", typeof(Power10X))]
        [TestCase("lnx", typeof(lnx))]
        public void AddTest(string name, Type expected)
        {
            ISingleCalculator calc = CalculatorSingleFactory.CreateCalculator(name);
            Assert.IsInstanceOf(expected, calc);
        } 
    }
}