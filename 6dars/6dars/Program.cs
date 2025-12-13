namespace _6dars
{
    internal class Program
    {
        //1Exercise

        static float Add(float a, float b)
        {
            return a + b;
        }

        static float Add(float a, float b, float c)
        {
            return a + b + c;
        }

        static string Add(string a, string b)
        {
            return a + b;
        }

        //2Exercise

        static int Multiplication(int a)
        {
            int res = 1;
            for (int i = 1; i <= a; i++)
            {
                res *= i;
            }

            return res;
        }

        static int Multiplication(int a, int b)
        {
            int res = 1;
            for (int i = a; i <= b; i++)
            {
                res *= i;
            }

            return res;
        }

        static int Multiplication(int a, int b, int c)
        {
            return a * b * c;
        }

        //3Exercise
        static int Calculate(int num1, int num2)
        {
            return num1 + num2;
        }
        static int Calculate(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }

        //4exercise

        static int GetAmountDigit(int number)
        {
            number = Math.Abs(number);

            if (number == 0)
                return 1;

            int count = 0;
            while (number > 0)
            {
                count++;
                number /= 10;
            }
            return count;
        }

        static int GetAmountDigit(string text)
        {
            int count = 0;

            foreach (char c in text)
            {
                if (c >= '0' && c <= '9')
                {
                    count++;
                }
            }
            return count;
        }


        //5
        static int findMax(int a, int b, int c)
        {
            return Math.Max(a, Math.Max(b, c));
        }

        static int findMax(int a, int b, int c, int d)
        {
            return Math.Max(findMax(a, b, c), d);
        }

        static int findMax(int a, int b, int c, int d, int e)
        {
            return Math.Max(findMax(a, b, c, d), e);
        }



        //6
        static int multiplication(int n)
        {
            int result = 1;

            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }

        static int multiplication(int a, int b)
        {
            int result = 1;

            for (int i = a; i <= b; i++)
            {
                result *= i;
            }

            return result;
        }

        static int multiplication(int a, int b, int c)
        {
            return a * b * c;
        }




        //7
        static int CountDigits(int number)
        {
            number = Math.Abs(number);

            if (number < 10)
            {
                return 1;
            }

            return 1 + CountDigits(number / 10);
        }



        //8
        static int SumBetween(int a, int b)
        {
            if (a > b)
            {
                return 0;
            }

            return a + SumBetween(a + 1, b);
        }





        //9
        static int SumOfCubes(int n)
        {
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += i * i * i;
            }
            return sum;
        }





        static void Main(string[] args)
        {
            //1
            //Console.WriteLine(Add(2.5f, 3.5f));
            //Console.WriteLine(Add(2.1f, 3f, 7.7f));
            //Console.WriteLine(Add("Salom", "Dunyo"));

            //2
            //Console.WriteLine(Multiplication(4));
            //Console.WriteLine(Multiplication(3, 6));
            //Console.WriteLine(Multiplication(1, 2, 3));

            //3
            //Console.WriteLine(Calculate(4, 5));
            //Console.WriteLine(Calculate(2, 5, 6));

            //4
            //Console.WriteLine(GetAmountDigit(42322));
            //Console.WriteLine(GetAmountDigit("ejh2b34b3bhw"));

            //5
            

            //6
            Console.WriteLine(multiplication(4));
            Console.WriteLine(multiplication(94));
            Console.WriteLine(multiplication(123));

            //7
            Console.WriteLine(CountDigits(4275));

            //8
            Console.WriteLine(SumBetween(4,8));

            //9
            Console.WriteLine(SumOfCubes(7));
        }
    }
}
