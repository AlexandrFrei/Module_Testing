using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Module_testing_lab;

namespace Module_testing_lab_Tests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void MAIN_test()
        {
            MyInt expected = new MyInt(-76);
            MyInt a = new MyInt(154); // Создание из целого числа 
            MyInt b = new MyInt("-230");     // Создание из строки 
            MyInt c = a.Add(b);      // c = a + b; 
            MyInt max = c.maximum(a);      // Максимум из а и с 
            long d = c.longValue();      // преобразование к long 

            int q1 = expected.Znach;
            int q2 = c.Znach;

            Assert.AreEqual(q1, q2);
        }

        [TestMethod]
        public void Add_test()
        {
            MyInt expected = new MyInt(180);

            MyInt a = new MyInt(168);
            MyInt b = new MyInt("12");

            MyInt actual = a.Add(b);
            int q1 = expected.Znach;
            int q2 = actual.Znach;
            Assert.AreEqual(q1, q2);
        }

        [TestMethod]
        public void Sub_test()
        {
            MyInt expected = new MyInt(138);

            MyInt a = new MyInt("18");
            MyInt b = new MyInt(-120);
            MyInt actual = a.subtrackt(b);

            int q1 = expected.Znach;
            int q2 = actual.Znach;
            Assert.AreEqual(q1, q2);
        }

        [TestMethod]
        public void Mul_test()
        {
            MyInt expected = new MyInt(0);

            MyInt a = new MyInt(0);
            MyInt b = new MyInt(-10);
            MyInt actual = a.multiply(b);

            int q1 = expected.Znach;
            int q2 = actual.Znach;
            Assert.AreEqual(q1, q2);
        }

        [TestMethod]
        public void Max_test()
        {
            MyInt expected = new MyInt(0);

            MyInt a = new MyInt(0);
            MyInt b = new MyInt(0);
            MyInt actual = a.maximum(b);

            int q1 = expected.Znach;
            int q2 = actual.Znach;
            Assert.AreEqual(q1, q2);
        }

        [TestMethod]
        public void Min_test()
        {
            MyInt expected = new MyInt(-1);

            MyInt a = new MyInt("-1");
            MyInt b = new MyInt(150);
            MyInt actual = a.minimum(b);
            int q1 = expected.Znach;
            int q2 = actual.Znach;
            Assert.AreEqual(q1, q2);
        }

        [TestMethod]
        public void Abs_test()
        {
            MyInt expected = new MyInt(123);

            MyInt a = new MyInt("-123");
            MyInt actual = a.Abs();
            int q1 = expected.Znach;
            int q2 = actual.Znach;
            Assert.AreEqual(q1, q2);
        }

        [TestMethod]
        public void Compare_test()
        {
            bool expected = true;

            MyInt a = new MyInt("15");
            MyInt b = new MyInt(15);
            bool actual = a.compareTo(b);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void gcd_test()
        {
            MyInt expected = new MyInt(25);

            MyInt a = new MyInt(75);
            MyInt b = new MyInt(25);
            MyInt actual = a.gcd(b);
            int q1 = expected.Znach;
            int q2 = actual.Znach;
            Assert.AreEqual(q1, q2);
        }

        [TestMethod]
        public void toStr_test()
        {
            string expected = "25";

            MyInt a = new MyInt(25);
            string actual = a.toString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void toLong_test()
        {
            long expected = 7536;

            MyInt a = new MyInt("7536");
            long actual = a.longValue();
            Assert.AreEqual(expected, actual);
        }

    }
}
