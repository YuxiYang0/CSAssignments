using System;
using System.Numerics;

namespace CombinedConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //All exercises are contained in this file.
            //To test other ones, simply replace NameGenerator with other class names.
            NameGenerator.Run();
        }
    }

    class NameGenerator
    {
        public static void Run()
        {
            Console.WriteLine("Welcome to the Hacker Name Generator!");

            Console.Write("Enter your favorite color: ");
            string favoriteColor = Console.ReadLine();

            Console.Write("Enter your astrology sign: ");
            string astrologySign = Console.ReadLine();

            Console.Write("Enter your street address number: ");
            string streetAddressNumber = Console.ReadLine();

            string hackerName = $"{favoriteColor}{astrologySign}{streetAddressNumber}";

            Console.WriteLine($"Your hacker name is {hackerName}.");
        }
    
    }

    class UnderstandingTypes
    {
        public static void Run()
        {
            Console.WriteLine("{0,-10} {1,-20} {2,-30} {3,-30}", "Type", "Byte(s) of memory", "Min", "Max");
            Console.WriteLine("{0,-10} {1,-20} {2,-30} {3,-30}", "----", "----------------", "---", "---");
            Console.WriteLine("{0,-10} {1,-20} {2,-30} {3,-30}", "sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
            Console.WriteLine("{0,-10} {1,-20} {2,-30} {3,-30}", "byte", sizeof(byte), byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0,-10} {1,-20} {2,-30} {3,-30}", "short", sizeof(short), short.MinValue, short.MaxValue);
            Console.WriteLine("{0,-10} {1,-20} {2,-30} {3,-30}", "ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
            Console.WriteLine("{0,-10} {1,-20} {2,-30} {3,-30}", "int", sizeof(int), int.MinValue, int.MaxValue);
            Console.WriteLine("{0,-10} {1,-20} {2,-30} {3,-30}", "uint", sizeof(uint), uint.MinValue, uint.MaxValue);
            Console.WriteLine("{0,-10} {1,-20} {2,-30} {3,-30}", "long", sizeof(long), long.MinValue, long.MaxValue);
            Console.WriteLine("{0,-10} {1,-20} {2,-30} {3,-30}", "ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
            Console.WriteLine("{0,-10} {1,-20} {2,-30} {3,-30}", "float", sizeof(float), float.MinValue, float.MaxValue);
            Console.WriteLine("{0,-10} {1,-20} {2,-30} {3,-30}", "double", sizeof(double), double.MinValue, double.MaxValue);
            Console.WriteLine("{0,-10} {1,-20} {2,-30} {3,-30}", "decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue);
        }
    
    }

    class CenturiesConversion
    {
        public static void Run()
        {
            Console.Write("Enter the number of centuries: ");
            int centuries = int.Parse(Console.ReadLine());

            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            long hours = days * 24L;
            long minutes = hours * 60L;
            long seconds = minutes * 60L;
            long milliseconds = seconds * 1000L;
            BigInteger microseconds = milliseconds * 1000L;
            BigInteger nanoseconds = microseconds * 1000L;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }

    class FizzBuzz
    {
        public static void Run()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    class GuessNumber
    {
        public static void Run()
        {
            int correctNumber = new Random().Next(3) + 1;
            Console.WriteLine("Guess a number between 1 and 3:");
            int guessedNumber = int.Parse(Console.ReadLine());

            if (guessedNumber < 1 || guessedNumber > 3)
            {
                Console.WriteLine("Your guess is outside the valid range.");
            }
            else if (guessedNumber < correctNumber)
            {
                Console.WriteLine("Your guess is too low.");
            }
            else if (guessedNumber > correctNumber)
            {
                Console.WriteLine("Your guess is too high.");
            }
            else
            {
                Console.WriteLine("Congratulations! You guessed the correct number.");
            }
        }
    }

    class PrintAPyramid
    {
        public static void Run()
        {
            int height = 5;
            for (int i = 1; i <= height; i++)
            {
                for (int j = 0; j < height - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }

    class DaysOldCalculator
    {
        public static void Run()
        {
            DateTime birthDate = new DateTime(1990, 1, 1);
            TimeSpan age = DateTime.Now - birthDate;
            int daysOld = age.Days;
            Console.WriteLine($"You are {daysOld} days old.");

            int daysToNextAnniversary = 10000 - (daysOld % 10000);
            DateTime nextAnniversary = DateTime.Now.AddDays(daysToNextAnniversary);
            Console.WriteLine($"Your next 10,000 day anniversary will be on {nextAnniversary.ToShortDateString()}.");

        }
    }

    class TimeBasedGreeting
    {
        public static void Run()
        {
            DateTime currentTime = DateTime.Now;
            int hour = currentTime.Hour;

            if (hour >= 6 && hour < 12)
            {
                Console.WriteLine("Good Morning");
            }
            if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("Good Afternoon");
            }
            if (hour >= 18 && hour < 22)
            {
                Console.WriteLine("Good Evening");
            }
            if (hour >= 22 || hour < 6)
            {
                Console.WriteLine("Good Night");
            }
        }
    }

    class CountingIncrements
    {
        public static void Run()
        {
            for (int increment = 1; increment <= 4; increment++)
            {
                for (int i = 0; i <= 24; i += increment)
                {
                    Console.Write(i + (i < 24 ? "," : ""));
                }
                Console.WriteLine();
            }
        }
    }

    class CopyArray
    {
        public static void Run()
        {
            int[] originalArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] copiedArray = new int[originalArray.Length];

            for (int i = 0; i < originalArray.Length; i++)
            {
                copiedArray[i] = originalArray[i];
            }

            Console.WriteLine("Original Array: " + string.Join(", ", originalArray));
            Console.WriteLine("Copied Array: " + string.Join(", ", copiedArray));

        }
    }

    class UserManagedList
    {
        public static void Run()
        {
            List<string> list = new List<string>();

            while (true)
            {
                Console.WriteLine("Enter command (+ item, - item, or -- to clear):");
                string input = Console.ReadLine();
                if (input.StartsWith("+"))
                {
                    list.Add(input.Substring(2));
                }
                else if (input.StartsWith("-"))
                {
                    list.Remove(input.Substring(2));
                }
                else if (input == "--")
                {
                    list.Clear();
                }
                Console.WriteLine("Current List: " + string.Join(", ", list));
            }
        }
    }

    class FindPrime
    {
        public static void Run()
        {
            int[] primes = FindPrimesInRange(1, 100);
            Console.WriteLine("Primes in range: " + string.Join(", ", primes));
        }

        static int[] FindPrimesInRange(int startNum, int endNum)
        {
            List<int> primes = new List<int>();
            for (int num = startNum; num <= endNum; num++)
            {
                if (IsPrime(num))
                {
                    primes.Add(num);
                }
            }
            return primes.ToArray();
        }
        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

    }

    class ArrayRotator
    {
        public static void Run()
        {
            int[] array = { 3, 2, 4, -1 };
            int k = 2;
            int[] sumArray = new int[array.Length];

            for (int r = 1; r <= k; r++)
            {
                int[] rotatedArray = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    rotatedArray[(i + r) % array.Length] = array[i];
                }
                for (int i = 0; i < array.Length; i++)
                {
                    sumArray[i] += rotatedArray[i];
                }
            }

            Console.WriteLine("Rotated and summed array: " + string.Join(" ", sumArray));

        }
    }

    class LongestSequenceFinder
    {
        public static void Run()
        {
            int[] array = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
            int bestStart = 0, bestLength = 1, currentStart = 0, currentLength = 1;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {
                    currentLength++;
                    if (currentLength > bestLength)
                    {
                        bestLength = currentLength;
                        bestStart = currentStart;
                    }
                }
                else
                {
                    currentLength = 1;
                    currentStart = i;
                }
            }

            Console.Write("Longest sequence: ");
            for (int i = bestStart; i < bestStart + bestLength; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }

    class MostFrequentNumberFinder
    {
        public static void Run()
        {
            int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            Dictionary<int, int> frequency = new Dictionary<int, int>();

            foreach (int number in array)
            {
                if (!frequency.ContainsKey(number))
                {
                    frequency[number] = 0;
                }
                frequency[number]++;
            }

            int mostFrequentNumber = array[0];
            int maxFrequency = frequency[mostFrequentNumber];

            foreach (KeyValuePair<int, int> pair in frequency)
            {
                if (pair.Value > maxFrequency)
                {
                    mostFrequentNumber = pair.Key;
                    maxFrequency = pair.Value;
                }
            }

            Console.WriteLine($"The number {mostFrequentNumber} is the most frequent (occurs {maxFrequency} times)");
        }
    }

    class StringReverser
    {
        public static void Run()
        {
            string input = "sample";
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string reversed = new string(charArray);
            Console.WriteLine(reversed);
        }
    }

    class StringReverserLoop
    {
        public static void Run()
        {
            string input = "24tvcoi92";
            string reversed = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed += input[i];
            }
            Console.WriteLine(reversed);
        }
    }

    class SentenceReverser
    {
        public static void Run()
        {
            string sentence = "C# is not C++, and PHP is not Delphi!";
            string[] words = sentence.Split(new char[] { '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(words);
            string reversedSentence = string.Join(" ", words);
            Console.WriteLine(reversedSentence);
        }
    }

    class PalindromeExtractor
    {
        public static void Run()
        {
            string text = "Hi,exe? ABBA! Hog fully a string: ExE. Bob";
            string[] words = text.Split(new char[] { '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            HashSet<string> palindromes = new HashSet<string>();

            foreach (string word in words)
            {
                if (IsPalindrome(word))
                {
                    palindromes.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ", palindromes.OrderBy(x => x)));
        }

        private static bool IsPalindrome(string word)
        {
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }




    class UrlParser
    {
        public static void Run()
        {
            ParseUrl("https://www.apple.com/iphone");
            Console.WriteLine();
            ParseUrl("ftp://www.example.com/employee");
            Console.WriteLine();
            ParseUrl("https://google.com");
            Console.WriteLine();
            ParseUrl("www.apple.com");
        }

        private static void ParseUrl(string url)
        {
            string protocol = "";
            string server = "";
            string resource = "";

            int protocolEndIndex = url.IndexOf("://");
            if (protocolEndIndex != -1)
            {
                protocol = url.Substring(0, protocolEndIndex);
                url = url.Substring(protocolEndIndex + 3);
            }

            int serverEndIndex = url.IndexOf("/");
            if (serverEndIndex != -1)
            {
                server = url.Substring(0, serverEndIndex);
                resource = url.Substring(serverEndIndex + 1);
            }
            else
            {
                server = url;
            }

            Console.WriteLine($"[protocol] = \"{protocol}\"");
            Console.WriteLine($"[server] = \"{server}\"");
            Console.WriteLine($"[resource] = \"{resource}\"");
        }
    }



}
