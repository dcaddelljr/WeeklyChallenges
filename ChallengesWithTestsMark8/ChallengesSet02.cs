using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c) //=> char.IsLetter(c);
        {
           /* var alpha = "abcdefghijklmnopqrstuvwxyz";
            return alpha.Contains(char.ToLower(c));

            return char.IsLetter(c);*/
            return (c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z');
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            return false;

            //return (vals.Length % 2 == 0) ? true : false;
        }

        public bool IsNumberEven(int number)
        {
            return (number % 2 == 0) ? true: false;
        }

        public bool IsNumberOdd(int num)
        {
            /*return (num % 2 != 0) ? true : false;*/
            return num % 2 != 0;
        }

        public static double SumOfMinAndMax(IEnumerable<double> numbers) // <--similar to a list
        {
            /*if (numbers == null)  GETTING ERROR OF SumOfMinAndMax....
            {
                return 0;
            }

            double min = 0;
            double max = 0;

            foreach (var num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }
                if (num < min)
                {
                    min = num;
                }
                if (numbers.Count() <= 1)
                {
                    min = num;
                }

                return min + max;*/
            { 
                return (numbers == null || numbers.Count() == 0) ? 0 : numbers.Min() + numbers.Max();
            }
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            /*if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }*/

        return (str1.Length < str2.Length) ? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        {

        /*if (numbers == null)
        {
            return 0;
        }
        var sum = 0;

        for (var i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        return sum;*/
        return numbers?.Sum() ?? 0;
        }

        public int SumEvens(int[] numbers)
        {
            /*if ( numbers == null)
            {
                 return 0;
            }

             var evenSum = 0;

            for (var i = 0; 1 < numbers.Length; i++)
            {
                evenSum += numbers[i];
            }
                 return evenSum;*/
            return numbers?.Where(num => num % 2 == 0).Sum() ?? 0;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            /*if (numbers == null)
            {
                return false;
            }

            var sum = 0;

            foreach (var num in numbers)
            {
                sum += num;
            }
            return (sum % 2 != 0);*/

            return (numbers == null) ? false : (numbers.Sum() % 2 != 0);
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            /*if (number <= 0)
                return 0;
            else
                return number / 2;*/
            return (number <= 0) ? 0 : number / 2;
        }
    }
}
