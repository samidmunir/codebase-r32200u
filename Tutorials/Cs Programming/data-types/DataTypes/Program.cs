using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Data Types");

            int age = 23;
            Console.WriteLine("(int) age: " + age);

            long bigNum = 556967123000L;
            Console.WriteLine("(long) bigNum: " + bigNum);

            double decimalNum = 3.147;
            Console.WriteLine("(double) decimalNum: " + decimalNum);

            double floatNum = 5.00000000213F;
            Console.WriteLine("(float) floatNum: " + floatNum);

            decimal money = 15.99M;
            Console.WriteLine("(decimal) money: " + money);

            Console.ReadLine();
        }
    }
}