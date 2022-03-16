namespace Day12Demo;

public class ParametersDemo
{
    //Value Parameter
    // 1. 100,200
    // 2. 10,20
    // 3. 100,200, Ans = 300

    // Ref Parameter
    // 1. 100,200
    // 2. 10,20
    // 3. 10,20,300

    public static void Test()
    {
        int num1 = 100, num2 = 200;
        Console.WriteLine($"1. {num1},{num2}");

        var ans1 = ValueParamTest(num1, num2);
        Console.WriteLine($"3. {num1},{num2},Ans={ans1}");

        var ans2 = RefParamTest(ref num1, ref num2);
        Console.WriteLine($"3. {num1},{num2},Ans={ans2}");

        var ans3 = OutParamTest(out num1, out num2);
        Console.WriteLine($"3. {num1},{num2},Ans={ans3}");

        DefaultParamTest("Hello", 10);
        DefaultParamTest("World");

        NamedParamTest("Raman", 30, 5000);
        NamedParamTest(salary: 5000, name: "Raman1", age: 50);

        NamedParamTest("chaman");
        NamedParamTest("faman", 20);
        NamedParamTest("maman", 25, 11000);
        NamedParamTest("maman", salary: 11000);

        int[] arr = { 55, 66, 77, 22, 44 };
        ParamsParamTest(arr);

        ParamsParamTest(10, 20);
        ParamsParamTest(10, 20, 30, 40, 50, 60);
        ParamsParamTest(10, 20, 30, 40, 50, 60, 10, 20, 30, 40, 50, 60, 10, 20, 30, 40, 50, 60);
        ParamsParamTest(1);
    }

    public static int ValueParamTest(int num1, int num2)
    {
        int ans = num1 + num2;

        num1 = 10;
        num2 = 20;

        Console.WriteLine($"2. {num1},{num2}");

        return ans;
    }

    public static int RefParamTest(ref int num1, ref int num2)
    {
        int ans = num1 + num2;

        num1 = 10;
        num2 = 20;

        Console.WriteLine($"2. {num1},{num2}");

        return ans;
    }

    public static int OutParamTest(out int num1, out int num2)
    {
        num1 = 10;
        num2 = 20;

        int ans = num1 + num2;

        Console.WriteLine($"2. {num1},{num2}");

        return ans;
    }

    public static void DefaultParamTest(string message, int noOfTimes = 1)
    {
        for (int i = 1; i <= noOfTimes; i++)
        {
            Console.WriteLine(message);
        }
    }

    public static void NamedParamTest(string name, int age = 18, float salary = 10000)
    {
        Console.WriteLine($"Name={name}, Age={age}, Salary={salary}");
    }

    public static void ParamsParamTest(params int[] arr)
    {
        Console.WriteLine("-----------------");
        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("-----------------");
    }
}

