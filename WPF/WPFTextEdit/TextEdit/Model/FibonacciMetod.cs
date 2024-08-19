using System;
namespace TextEdit.Model
{
    public static class IntExtension
    {
        public static string GetFibonacciArray(this int n)
        {
            ulong f1 = 0, f2 = 1;
            string text = string.Empty;
            if (n == 1) text = "0";
            if (n > 1) text = "0 1";

            for (int i = 2; i < n; i++)
            {
                ulong next = f1 + f2;
                f1 = f2;
                f2 = next;
                text += " " + next;
            }

            return text;
        }

        public static string GetFibonacciArraySumm(this string textEdit)
        {
            string[] numbers = textEdit.Split(' ');
            int summ = 0;
            foreach (var number in numbers)
            {
                int a;
                int.TryParse(number, out a);
                summ += a;
            }
            return summ.ToString();
        }
    }
}
