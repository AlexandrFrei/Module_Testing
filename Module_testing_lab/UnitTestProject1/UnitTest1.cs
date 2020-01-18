using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Part2;

namespace Part2_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Main_Test2()
        {
            string expected = "a";
            DEQueue<String> q = new DEQueue<String>();     // Создание очереди для хранения строк 
            q.pushFront("a");       // очередь: a 
            q.pushFront("b");       // очередь: b a 
            q.pushBack("c");        // очередь: b a c 
            String s = q.front();    // s = “b” 
            s = q.pop();         // s = “c”;    очередь:  b a 

            Assert.AreEqual(expected, s);
        }

        [TestMethod]
        public void clear_Test2()
        {
            int expected = 0;
            DEQueue<String> q = new DEQueue<string>(); // Создание очереди для хранения строк 
            q.pushBack("a");
            q.pushBack("b");
            q.pushBack("c");
            q.pushBack("d");
            q.clearr();
            int s = q.size();

            Assert.AreEqual(expected, s);
        }

        [TestMethod]
        public void size_Test2()
        {
            int expected = 4;
            DEQueue<String> q = new DEQueue<string>(); // Создание очереди для хранения строк 
            q.pushBack("a");
            q.pushBack("b");
            q.pushBack("c");
            q.pushBack("d");
            int s = q.size();

            Assert.AreEqual(expected, s);
        }

        [TestMethod]
        public void front_Test2()
        {
            string expected = "a";
            DEQueue<String> q = new DEQueue<string>(); // Создание очереди для хранения строк 
            q.pushBack("a");
            q.pushBack("b");
            q.pushBack("c");
            q.pushBack("d");
            string s = q.front();

            Assert.AreEqual(expected, s);
        }

        [TestMethod]
        public void back_Test2()
        {
            string expected = "d";
            DEQueue<String> q = new DEQueue<string>(); // Создание очереди для хранения строк 
            q.pushBack("a");
            q.pushBack("b");
            q.pushBack("c");
            q.pushBack("d");
            string s = q.back();

            Assert.AreEqual(expected, s);
        }

        [TestMethod]
        public void pop_Test2()
        {
            string expected = "b";
            DEQueue<String> q = new DEQueue<string>(); // Создание очереди для хранения строк 
            q.pushBack("a");
            q.pushBack("b");
            q.pushBack("c");
            q.pushBack("d");
            q.pop();
            string s = q.front();

            Assert.AreEqual(expected, s);
        }

        [TestMethod]
        public void pushBack_Test2()
        {
            string expected = "5";
            DEQueue<String> q = new DEQueue<string>(); // Создание очереди для хранения строк 
            q.pushFront("5");  // 5
            q.pushFront("b");  // b 5
            q.pushFront("b");  // b b 5 
            q.pushFront("q");  // q b b 5
            string s = q.front();

            Assert.AreEqual(expected, s);
        }

        [TestMethod]
        public void pushFront_Test2()
        {
            string expected = "q";
            DEQueue<String> q = new DEQueue<string>(); // Создание очереди для хранения строк 
            q.pushFront("5");  // 5
            q.pushFront("b");  // b 5
            q.pushFront("b");  // b b 5 
            q.pushFront("q");  // q b b 5
            string s = q.back(); 

            Assert.AreEqual(expected, s);
        }
    }
}
