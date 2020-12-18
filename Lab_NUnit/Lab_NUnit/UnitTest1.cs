using NUnit.Framework;

namespace Lab_NUnit
{
    public class Tests
    {
        static object[] DivideCases1 = 
        {
            new object[] {2, 2, 4},
            new object[] {-15, 15, 0},
            new object[] {7, -10, -3}
        };

        [Test(Description = "Test addition"), TestCaseSource("DivideCases1")]
        public void TestPlus(int x, int y, int result)
        {
            int temp = Calculator.Plus(x, y);
            Assert.AreEqual(result, temp, "actual: {0} + {1} = {2}, expect: {3}", x, y, temp, result);
        }

        static object[] DivideCases2 =
        {
            new object[] {10, 5, 5},
            new object[] {-70, -15, -55},
            new object[] {100, 10, 90}
        };

        [Test(Description = "Test subtraction"), TestCaseSource("DivideCases2")]
        public void TestMinus(int x, int y, int result)
        {
            int temp = Calculator.Minus(x, y);
            Assert.AreEqual(result, temp, "actual: {0} - {1} = {2}, expect: {3}", x, y, temp, result);
        }

        static object[] DivideCases3 =
{
            new object[] {6, 6, 36},
            new object[] {-5, -10, 50},
            new object[] {33, 0, 0}
        };

        [Test(Description = "Test multiplication"), TestCaseSource("DivideCases3")]
        public void TestMultiplication(int x, int y, int result)
        {
            int temp = Calculator.Multiplication(x, y);
            Assert.AreEqual(result, temp, "actual: {0} * {1} = {2}, expect: {3}", x, y, temp, result);
        }

        static object[] DivideCases4 =
        {
            new object[] {5, 0, 0},
            new object[] {-18, 6, -3},
            new object[] {-10, -2, 5}
        };
        [Test(Description = "Test division"), TestCaseSource("DivideCases4")]
        public void TestDivision(int x, int y, int result)
        {
            int temp = Calculator.Division(x, y);
            Assert.AreEqual(result, temp, "actual: {0} / {1} = {2}, expect: {3}", x, y, temp, result);
        }

    }
}