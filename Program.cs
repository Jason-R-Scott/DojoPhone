using System;

namespace DojoPhone
{
    class Program
    {
        static void Main(string[] args)
        {
            Galaxy s8 = new Galaxy("s8", 100, "T-Mobile", "Dooo do doo doooo");
            Nokia elevenHundred = new Nokia("1100", 60, "Metro PCS", "Ooop I'm goin' ringey!");

            s8.DisplayInfo();
            System.Console.WriteLine(s8.Ring());
            System.Console.WriteLine(s8.Unlock());
            System.Console.WriteLine("");

            elevenHundred.DisplayInfo();
            System.Console.WriteLine(elevenHundred.Ring());
            System.Console.WriteLine(elevenHundred.Unlock());
            System.Console.WriteLine("");
        }
    }
}
