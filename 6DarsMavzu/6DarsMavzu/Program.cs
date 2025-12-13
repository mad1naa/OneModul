namespace _6DarsMavzu
{
    internal class Program
    {

        //--------- OVERLOADING --------- Funksiya

        static int GetMax(int a, int b)
        {
            return Math.Max(a, b);
        }

        static int GetMax(int a, int b, int c)
        {
            return Math.Max(a, Math.Max(b, c));
        }

        static string GetMax(string a, string b, string c)
        {
            return a;
        }


        //-----------  function default value-----------


        static string CustomSubstr(string s, int startIndex, int len = 0)
        {
            if (len == 0)
            {
                len = s.Length;
            }
            var res = string.Empty;
            for (var i = startIndex; i < len; i++)
            {
                res += s[i];
            }

            return res;
        }






        //Masala

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






        static void Main(string[] args)
        {
            // function overloading

            Console.WriteLine(GetMax(4, 8));
            Console.WriteLine(GetMax(4, 8, 5));
            Console.WriteLine(GetMax("32", "54", "77"));




            // function default value

            var s = "foundation";
            Console.WriteLine(CustomSubstr(s, 1));
            Console.WriteLine(CustomSubstr(s, 2, 4));

            //Masala

            Console.WriteLine(Multiplication(4));
            Console.WriteLine(Multiplication(3, 6));
            Console.WriteLine(Multiplication(1, 2, 3));

        }
    }
}
