using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Data Types");

            string text_age = "23";    
            int age = Convert.ToInt32(text_age);
            Console.WriteLine("(int) age: " + age);

            string text_bigNm = "556967123000";
            long bigNum = Convert.ToInt64(text_bigNm);
            Console.WriteLine("(long) bigNum: " + bigNum);

            string text_decimalNum = "3.147";
            double decimalNum = Convert.ToDouble(text_decimalNum);
            Console.WriteLine("(double) decimalNum: " + decimalNum);

            string text_floatNum = "5.00000000213";
            double floatNum = Convert.ToSingle(text_floatNum);
            Console.WriteLine("(float) floatNum: " + floatNum);

            string text_money = "15.99";
            decimal money = Convert.ToDecimal(text_money);
            Console.WriteLine("(decimal) money: " + money);

            string name = "Sami Munir";
            Console.WriteLine("(string) name: " + name);

            char letter = '$';
            Console.WriteLine("(char) letter: " + letter);

            bool bool_value = true;
            Console.WriteLine("(bool) bool_value: " + bool_value);

            Console.ReadLine();
        }
    }
}