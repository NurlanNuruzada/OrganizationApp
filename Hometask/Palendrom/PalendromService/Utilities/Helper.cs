namespace PalendromService.Utilities
{
    public static class Class1
    {
        public static bool IsPalindrome(this int num)
        {
            int FirstNum = num;
            int ReversedNum = 0;
            while (num > 0)
            {
                int digit = num % 10;
                ReversedNum = ReversedNum * 10 + digit;
                num /= 10;
            }

            return FirstNum == ReversedNum;
        }


    }
}