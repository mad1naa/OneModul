namespace _3DarsMavzu
{
    internal class Program
    {
        static void Main(string[] args)
        {
             //Loops(for, while, do while, foreach)


                //For Loop

                for (int i = 100; i <= 200; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write($"{i}, ");
                    }
                }


            // WHILE

            int i = 1;

            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }



            Random random = new Random();
            int randomNumber = random.Next(1, 100);

            int counter = 0;

            while (true) // break
            {
                Console.Write("Son kiriting : ");
                int num = int.Parse(Console.ReadLine());
                ++counter;
                if (num == randomNumber)
                {
                    Console.WriteLine("Urra Urra");
                    break;
                }

                if (counter == 6)
                {
                    Console.WriteLine("Game over");
                    Console.WriteLine($"Siz topolmagan son : {randomNumber}");
                    break;
                }

                if (num > randomNumber)
                {
                    Console.WriteLine("Kichikroq son kiriting");
                }

                else if (num < randomNumber)
                {
                    Console.WriteLine("Kattaroq son kiriting");
                }
            }



            // do while

            do
            {
                Console.WriteLine("1");
                Console.WriteLine("2");
            }
            while (true);



            // foreach

            string[] fruits = { "olma", "Banan", "anor", "Behi", "Nok", "Shaftoli" };

            foreach (string fruit in fruits)
            {
                int counter = 0;
                foreach (char ch in fruit)
                {
                    if (ch == 'a' || ch == 'u' || ch == 'i' || ch == 'o' || ch == 'e')
                    {
                        counter++;
                    }
                }
                Console.WriteLine($"{fruit} : {counter}");
            }



            // compile time vs run time

            var vs dynamic

           dynamic num = 10;

            num = "salom";

            num = 57;

            var num = 8;

            var text = "salom";

            text = "fcdngh";

            var check = true;


            // debugging

            Console.Write("3 xonali son kiriting : ");
            int num = int.Parse(Console.ReadLine());
            // 452
            int r1 = num / 1 % 10;
            int r2 = num / 10 % 10;
            int r3 = num / 1000 % 10;

            int res = r1 + r2 + r3;

            Console.WriteLine($"Result : {res}");



        }
    }
}
