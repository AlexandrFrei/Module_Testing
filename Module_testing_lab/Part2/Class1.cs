using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Part2
{
    public class DEQueue<T>: Queue<T>
    {
        public DEQueue()
        {

        }

    }

    public static class Methods
    {
        public static Part2.DEQueue<string> pushFront(this Part2.DEQueue<string> mass, string neww)
        {
            mass.Reverse();
            mass.Enqueue(neww);
            mass.Reverse();
            Part2.DEQueue<string> a = mass;
            return a;
        }

        public static Part2.DEQueue<string> pushBack(this Part2.DEQueue<string> mass, string neww)
        {
            mass.Enqueue(neww);  //добавляет элемент в конец
            return mass;
        }

        public static string pop(this Part2.DEQueue<string> mass)
        {
            return mass.Dequeue(); ;
        }

        public static string front(this Part2.DEQueue<string> mass)
        {
            return mass.Peek();
        }

        public static string back(this Part2.DEQueue<string> mass)
        {
            string a = mass.Last();
            return a;
        }

        public static int size(this Part2.DEQueue<string> mass)
        {
            return mass.Count;
        }

        public static void clearr(this Part2.DEQueue<string> mass)
        {
            mass.Clear();
        }

        public static Array toArray(this Part2.DEQueue<string> mass)
        {
            Array a = mass.ToArray();
            return a;
        }
    }


}
