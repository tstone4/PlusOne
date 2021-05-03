using System;

namespace PlusOne
{
    public class Program
    {
        static void Main()
        {
            int[] digits = new int[] {9,9,9,9};
            Program program = new Program();
            int[] result = program.PlusOne(digits);
            for(int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i]);
            }
        }


        public int[] PlusOne(int[] digits)
        {
            if (digits.Length == 0)
                return digits;

            if(digits[digits.Length - 1] != 9)
            {
                digits[digits.Length - 1] = digits[digits.Length - 1] + 1;
                return digits;
            }
            else
            {
                digits[digits.Length - 1] = 0;
                return helper(digits, digits.Length-2);
            }
        }


        public int[] helper (int[] digits, int index)
        {
            if (index == -1)
            {
                int[] newArray = new int[digits.Length + 1];
                newArray[0] = 1;
                for(int i = 1; i <= digits.Length; i++)
                {
                    newArray[i] = digits[i - 1];
                }
                return newArray;
            }
            if(digits[index] != 9)
            {
                digits[index] = digits[index] + 1;
                return digits;
            }
            else
            {
               digits[index] = 0;
               return helper(digits, index - 1);
            }
        }
    }
}
