using System;
using System.Text.RegularExpressions;

namespace Question2336627
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "Видаляє всi слова, передостання лiтера яких голосна";
            var pattern = @"\b[-\p{IsCyrillic}]*?[аєєиіїоуюя][-\p{IsCyrillic}]\b";
            var str2 = Regex.Replace(str, pattern, "", RegexOptions.IgnoreCase);
            Console.WriteLine(str2);
            Console.ReadKey();
        }
    }
}