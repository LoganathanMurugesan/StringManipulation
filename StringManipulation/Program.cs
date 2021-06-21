using System;
using System.Globalization;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            StringConversion();
        }

        private static void StringConversion()
        {
            string testString = "tHiS SHoULd bE iN LOwEr cAse";
            TextInfo currentTextInfo = CultureInfo.CurrentCulture.TextInfo;

            string result = testString.ToLower();
            Console.WriteLine(result);

            result = testString.ToUpper();
            Console.WriteLine(result);

            result = currentTextInfo.ToTitleCase(testString);
            Console.WriteLine(result);

        }
    }
}
