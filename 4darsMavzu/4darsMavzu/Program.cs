namespace _4darsMavzu;

internal class Program
{
    static void Main(string[] args)
    {
        //1_string

        string text = "salom Hello g13";

        //*Substring

        var res1 = text.Substring(6, 5);
        Console.WriteLine(res1);
        Console.WriteLine(text);



        //1.satr berilgan oxiridan 3 ta belgini ekranga chiqaring
        // TestCase
        // Input: "Foundation"  output: "ion"
        // Input: "davay"  output: "vay"

        string str = "davay";

        var res = str.Substring(str.Length - 3);
        Console.WriteLine(res);



        //2.satr berilgan oxiridan oxiridan 2 ta boshidan 2 ta
        //olmasdan o'rtadagi belgilarni chiqaring
        // TestCase
        // Input: "Foundation"  output: "undati"
        // Input: "davay"  output: "v"


        string str = "Foundation";

        var res = str.Substring(2, str.Length - 4);
        Console.WriteLine(res);







        //2_Remove

        var str = "Uzbekiston";

        var res = str.Remove(0, 20);

        Console.WriteLine(str);
        Console.WriteLine(res);





        // Contains - ichida bormi yomi shuni tekshirib beradi! boolen qaytaradi!

        string str = "Hello World World World";

        var res = str.Contains("World");

        Console.WriteLine(res);




        // Trim - sepes yani oxiridagi va boshidagi boshliqlarni ochirib tashlaydi!
        //1
        string str = "****Hello ** fd ** World*****";

        var res = str.Trim('*');

        Console.WriteLine(res);
        Console.WriteLine(str);

        //2
        string str = "    Hello ** fd ** World    ";

        var res = str.Trim();

        Console.WriteLine(res);
        Console.WriteLine(str);







        // IndexOf - berilgan sozni boshlangan indeksini qaytaradi!

        string str = "Hello World World World";

        var res1 = str.IndexOf("World");
        var res2 = str.IndexOf("World", 7);   // sozni 7 indeksdan boshlab qidiradi!
        var res3 = str.IndexOf("jdfh");

        Console.WriteLine(res1);
        Console.WriteLine(res2);
        Console.WriteLine(res3);



        // string.Empty

        var str = "";// string.Empty detiladi 
        var str1 = string.Empty;

        if ("" == string.Empty)
        {
            Console.WriteLine("dskjfv");
        }
    }
}





//char.IsLetter(); // harflikga tekshiradi
//char.IsDigit(); // raqamlikka tekshiradi
//char.IsWhiteSpace(); // bo'sh joyga tekshiradi
//char.IsUpper(); // katta harfga tekshiradi
//char.IsLower(); // kichik harfga tekshiradi






// FUNKSIYA
//Turi: Return typ    STRING QAYTARADI!   Returin yozish shart!

namespace _4darsMavzu;

internal class Program
{
     //1
    static string RemoveDigits(string str) 
    {
        // "S2L45trg8" RAQAMLARNI OCHIRIB BERADI

        for (var i = 0; i < str.Length; i++)
        {
            if (char.IsDigit(str[i]))
            {
                str = str.Remove(i, 1);
                i--;
            }
        }
        return str;

        //2 Kotta harflarni sanab beradi!
        static int GetCountOfCapitalLetter(string s)
        {
            int count = 0;
            for (var i = 0; i < s.Length; i++)
            {
                if (char.IsUpper(s[i]))
                {
                    count++;
                }
            }

            return count;
        }

    }
    static void Main(string[] args)
    {
        //1
        var res = RemoveDigits("S2L45trg8");

        Console.WriteLine(res);

        //2
        var str = "Salom Dunyo! Hello World! G13 .net";

        Console.WriteLine(GetCountOfCapitalLetter(str));

    }
}
