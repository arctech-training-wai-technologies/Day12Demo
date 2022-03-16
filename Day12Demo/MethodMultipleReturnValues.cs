using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12Demo
{
    public class MethodMultipleReturnValues
    {

        public static void Test()
        {
            int a, b, c;
            OutParamTest(out a, out b, out c);
            Console.WriteLine($"{a},{b},{c}");

            var tupleResponse = ReturnTupleTest();
            Console.WriteLine($"{tupleResponse.Item1},{tupleResponse.Item2},{tupleResponse.Item3}");

            var newTupleSyntax = ReturnTest();
            Console.WriteLine($"{newTupleSyntax.Item1},{newTupleSyntax.Item2},{newTupleSyntax.Item3},{newTupleSyntax.Item4}");

            var (num1, num2, num3, someString) = ReturnTest();
            Console.WriteLine($"{num1},{num2},{num3},{someString}");
        }

        public static void OutParamTest(out int num1, out int num2, out int num3)
        {
            num1 = 10;
            num2 = 20;
            num3 = num1 + num2;
        }

        // C# version 4
        public static Tuple<int, int, int> ReturnTupleTest()
        {
            int num1, num2, num3;
            num1 = 10;
            num2 = 20;
            num3 = num1 + num2;

            return Tuple.Create(num1, num2, num3);
        }

        // C# version 7
        public static (int, int, int, string) ReturnTest()
        {
            int num1, num2, num3;
            num1 = 10;
            num2 = 20;
            num3 = num1 + num2;

            return (num1, num2, num3, "Hello World");
        }
    }
}
