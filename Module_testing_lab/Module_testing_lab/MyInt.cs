using System;

namespace Module_testing_lab
{
    public class MyInt
    {
        public MyInt(int a)
        {
            Znach = a;
        }

        public MyInt(string a)
        {
            var q = int.TryParse(a, out int qq);
            Znach = qq;
        }

        public int Znach { get; }
    }
    
    public static class Methods
    {
        public static MyInt Add(this MyInt a, MyInt b)
        {
            int number1 = a.Znach;
            int number2 = b.Znach;
            int Sum = number1 + number2;
            MyInt otvet = new MyInt(Sum);
            return otvet;
        }

        public static MyInt subtrackt(this MyInt a, MyInt b)
        {
            int number1 = a.Znach;
            int number2 = b.Znach;
            int razn = number1 - number2;
            MyInt otvet = new MyInt(razn);
            return otvet;
        }

        public static MyInt multiply(this MyInt a, MyInt b)
        {
            int number1 = a.Znach;
            int number2 = b.Znach;
            int razn = number1 * number2;
            MyInt otvet = new MyInt(razn);
            return otvet;
        }

        public static MyInt maximum(this MyInt a, MyInt b)
        {
            int number1 = a.Znach;
            int number2 = b.Znach;
            int q = number2;
            if (number1 > number2) { q = number1; }
            MyInt otvet = new MyInt(q);
            return otvet;
        }

        public static MyInt minimum(this MyInt a, MyInt b)
        {
            int number1 = a.Znach;
            int number2 = b.Znach;
            int q = number2;
            if (number1 < number2) { q = number1; }
            MyInt otvet = new MyInt(q);
            return otvet;
        }

        public static MyInt Abs(this MyInt a)
        {
            int q = Math.Abs(a.Znach);
            MyInt otvet = new MyInt(q);
            return otvet;
        }

        public static bool compareTo(this MyInt a, MyInt b)
        {
            int number1 = a.Znach;
            int number2 = b.Znach;

            if (number1==number2) { return true; }
            else { return false; }
        }

        public static MyInt gcd(this MyInt a, MyInt b) //наибольший общ делитель
        {
            int number1 = a.Znach;
            int number2 = b.Znach;

            int min = 1;
            int i = min;
            int c = 0;

            if (number1 > number2) { min = number2; }
            else { min = number1; }

            while (i > 0 && c == 0)
            {
                if ((number1 % i == 0) && (number2 % i == 0))
                    c = i;
                i--;
            }
;
            MyInt otvet = new MyInt(min);
            return otvet;
        }

        public static string toString(this MyInt a)
        {
            string str = a.Znach.ToString();
            return str;
        }

        public static long longValue(this MyInt a)
        {
            string num = a.Znach.ToString();
            bool number = long.TryParse(num, out long q);
            return q;
        }
    }
}

