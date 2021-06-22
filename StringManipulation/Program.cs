using System;
using System.Diagnostics;
using System.Globalization;
using System.Text;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringConversion();
            //StringAsArray();
            //StringBuilderDemo();
            WorkingWithArrays();
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

        private static void StringAsArray()
        {
            string name = "Loganathan";

            for(int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
        }

        private static void StringBuilderDemo()
        {
            Stopwatch stopwatch = new();
            stopwatch.Start();

            string str = "0";

            for(int i = 0; i < 10000; i++)
            {
                str += i;
            }

            stopwatch.Stop();

            Console.WriteLine($"Time taken in milli seconds for string: {stopwatch.ElapsedMilliseconds}");



            Stopwatch builderStopwatch = new();
            builderStopwatch.Start();

            StringBuilder strBuilder = new();

            for (int i = 0; i < 1000000; i++)
            {
                strBuilder.Append(i);
            }

            builderStopwatch.Stop();

            Console.WriteLine($"Time taken in milli seconds for stringbuilder: {builderStopwatch.ElapsedMilliseconds}");
        }

        private static void WorkingWithArrays()
        {
            int[] ages = { 1,2,3,4,5,6,7,8};
            string results;

            results = String.Concat(ages);
            Console.WriteLine(results);

            results = String.Join("->",ages);
            Console.WriteLine(results);

            string testString = "A,B,C,D,E,F";
            string[] result = testString.Split(',');

            Array.ForEach(result, x => Console.WriteLine(x));
        }

        private static void RemoveDuplicateCharacterFromString()
        {
            string str = "Loganathan";
            int strLength = str.Length;
            string result = "";

            for (int i = 0; i < strLength; i++)
            {
                if (!result.Contains(str[i]))
                {
                    result += str[i];
                }
            }

            Console.WriteLine(result);
        }

        private static void CountTheOccururencesOfCharacter()
        {
            string str = "Loganathan";
            int strLength = str.Length;
            int total = 1;

            for (int i = 0; i < strLength; i++)
            {
                for (int j = 1; j < strLength; j++)
                {
                    if (str[i] == str[j])
                    {
                        total++;
                    }
                }
                Console.WriteLine($"{str[i]} has total of {total}");
                total = 0;
            }
        }

        private static void ReverseWordsInSentenceWithoutChangingTheOrder()
        {
            string str = "The path of the righteous man is beset on all sides";
            string[] strArray = str.Split(" ");
            string result = "";

            for (int i = 0; i < strArray.Length; i++)
            {
                for (int j = strArray[i].Length - 1; j >= 0; j--)
                {
                    result += strArray[i][j];
                }

                result += " ";
            }

            Console.WriteLine(result);
        }

        private static void RevereseStringAndPalindrome()
        {
            string str = "madam";
            int strLength = str.Length - 1;
            string result = "";

            for (int i = strLength; i >= 0; i--)
            {
                result += str[i];
            }

            if (str == result)
                Console.WriteLine($"{str} is a palindrome");
            else
                Console.WriteLine($"{str} is not a palindrome");

            Console.WriteLine(result);
        }
    }
}
