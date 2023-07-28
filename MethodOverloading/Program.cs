namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            int x = 25;
            int y = 15;

            var intAdd = Add(x, y);
            Console.WriteLine(intAdd);

            var decAdd = Add(100.50m, 200m);
            Console.WriteLine(decAdd);

            var boolAdd = Add(4, 4, true);
            Console.WriteLine(boolAdd);
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool withDollars)
        {
            int sum = num1 + num2;

            if (withDollars && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (withDollars && sum == 1)
            {
                return $"{sum} dollar";
            }

            return $"{sum}";
        }
    }
}


