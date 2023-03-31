using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            /*//foreach (bool val in vals)
            //{
            //    if (!val)
            //    {
            //        return true;
            //    }
            //}
            //return false;

            //for (var i = 0; i < vals.Length; i++)
            //{
            //    if (vals[i] == false)
            //    {
            //        return true;
            //    }

            //}
            //return false;*/
            return vals.Contains(false);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            /*//if ( numbers == null)
            //{
            //    return false;
            //}
            //int sum = 0;
            //foreach (int num in numbers)
            //{
            //    if (num % 2 != 0)
            //    {
            //        sum += num;
            //    }
            //}
            //return sum % 2 != 0;*/
            /*if (numbers == null)
            {
                return false;
            }
            var odds = new List<int>();

            foreach (var num in numbers)
            {
                if (num % 2 != 0)
                {
                    odds.Add(num);
                }
            }

            var sumOdds = odds.Sum();

            return (sumOdds % 2 != 0);*/

            return (numbers == null) ? false : numbers.Where(x => x % 2 != 0).Sum() % 2 != 0;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var hasUpper = false;
            var hasLower = false;
            var hasNumber = false;

            /*//foreach (char c in password)
            //{
            //    if (char.IsUpper(c))
            //    {
            //        hasUpper = true;
            //    }
            //    else if (char.IsLower(c))
            //    {
            //        hasLower = true;
            //    }
            //    else if (char.IsDigit(c))
            //    {
            //        hasNumber = true;
            //    }
            //    if (hasUpper && hasLower && hasNumber)
            //    {
            //        return true;
            //    }
            //}
            //return false;*/
            /*for (var i = 0; i < password.Length; i++)
            {
                if (char.IsLower(password[i]))
                {
                    hasLower = true;
                }
                if (char.IsUpper(password[i]))
                {
                    hasUpper = true;
                }
                if (char.IsNumber(password[i]))
                {
                    hasNumber = true;
                }
            }
            if (hasLower == true && hasUpper == true && hasNumber == true)
            {
                return true;
            }
            else
            {
                return false;
            }*/

            return (password.Any(char.IsLower)) && password.Any(char.IsUpper) && password.Any(char.IsNumber);
        }

        public char GetFirstLetterOfString(string val)
        {
            /*string value = val;
            char firstLetter = value.First();
            return Convert.ToChar(firstLetter);

            return val.First();*/
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            /*string value = val;
            char lastLetter = value.Last();
            return (lastLetter);

            return val[val.Length - 1];
            
            return val.Last(); //LINQ*/
            return val[^1]; //the number works backwards from the end basically
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            /*if (divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;*/
            return (divisor == 0 )? 0 : dividend/divisor; 
        }

        public int LastMinusFirst(int[] nums)
        {
            /*int num;
            int firstDigit = nums.First();
            int lastDigit = nums.Last();
            num = Convert.ToInt32(Console.ReadLine());
            return lastDigit - firstDigit;

            return nums[nums.Length - 1] - nums[0];

            return nums[^1] - nums[0];*/
            return nums.Last() - nums.First();
        }

        public int[] GetOddsBelow100()
        {
            /*var nums = new List<int>();
            for (var i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    nums.Add(i);
                }
            }
            return nums.ToArray();*/

            return Enumerable.Range(0, 100).Where(x => x % 2 != 0).ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (var i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
