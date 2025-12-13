namespace _3Dars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1Exercise

            //for (var i = 1; i <= 20; i++)
            //{
            //    if (i > 0)
            //    {
            //        Console.WriteLine($"{i}");
            //    }
            //}

            //2Exercise


            //for(var i = 25; i <= 100; i++)
            //{
            //    if(i > 0)
            //    {
            //        Console.WriteLine($"{i}");
            //    }
            //}

            //3Exercise

            //for(var i = 12; i <= 200; i++)
            //{
            //    if(i > 0)
            //    {
            //        Console.WriteLine($"{i}");
            //    }
            //}

            //4Exercise

            //for (var i = 15; i >= 2; i--)
            //{
            //    if (i > 0)
            //    {
            //        Console.WriteLine($"{i}");
            //    }
            //}

            //5Eexercise

            //for (var i = 120; i >= 23; i--)
            //{
            //    if (i > 0)
            //    {
            //        Console.WriteLine($"{i}");
            //    }
            //}

            //6Exercise


            //for (var i = 10; i <= 50; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine($"{i}");
            //    }
            //}

            //7Exercise

            //for (var i = 120; i <= 250; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine($"{i}");
            //    }
            //}

            //8Exercise

            //for (var i = 100; i <= 50; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine($"{i}");
            //    }
            //}

            //9Exercise

            //for (var i = 80; i >= 20; i--)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine($"{i}");
            //    }
            //}

            //10Exercise

            //Console.Write("firsNumber:");
            //var firstNumber = int.Parse(Console.ReadLine());

            //Console.Write("secondNumber:");
            //var secondNumber = int.Parse(Console.ReadLine());

            //for (var i = firstNumber; i <= secondNumber; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.Write($"{i}, ");
            //    }

            //}

            //11Exercise

            //Console.Write("firsNumber:");
            //var firstNumber = int.Parse(Console.ReadLine());

            //Console.Write("secondNumber:");
            //var secondNumber = int.Parse(Console.ReadLine());

            //for (var i = firstNumber; i <= secondNumber; i++)
            //{
            //    if (i % 4 == 0 && i % 7 == 0)
            //    {
            //        Console.Write($"{i}, ");
            //    }

            //}

            //12Exercise

            //Console.Write("firsNumber:");
            //var firstNumber = int.Parse(Console.ReadLine());

            //Console.Write("secondNumber:");
            //var secondNumber = int.Parse(Console.ReadLine());

            //for (var i = firstNumber; i <= secondNumber; i++)
            //{
            //    if (i % 8 == 0)
            //    {
            //        Console.Write($"{i}, ");
            //    }

            //}

            //13Exercise

            //Console.Write("firsNumber:");
            //var firstNumber = int.Parse(Console.ReadLine());

            //Console.Write("secondNumber:");
            //var secondNumber = int.Parse(Console.ReadLine());

            //for (var i = firstNumber; i <= secondNumber; i++)
            //{
            //    if (i % 5 == 0 && i % 9 == 0)
            //    {
            //        Console.Write($"{i}, ");
            //    }
            //}

            //14Exercise

            //var result = 0;

            //for (var i = 1; i <= 100; i++)
            //{
            //    if (i % 2 != 0)
            //    {

            //        result += i;

            //    }
            //}
            //Console.WriteLine(result);

            //15Exercise

            Console.Write(" Enter three-digit number:");
            var number = int.Parse(Console.ReadLine());

            var numberFinally = 0;

            var r1 = 0; var r2 = 0; var r3 = 0;

            for (var i = 100; i <= 999; i++)
            {

                r1 = number / 1 % 10;
                r2 = number / 100 % 10;
                r3 = number / 1000 % 10;

                numberFinally = r1 + r2 + r3;

                if (numberFinally > 20)
                {
                    Console.WriteLine($"{numberFinally},");
                    Console.WriteLine($"{numberFinally},");
                    Console.WriteLine($"{numberFinally},");

                }
            }
        }
    }
}
