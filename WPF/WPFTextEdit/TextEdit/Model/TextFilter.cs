using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace TextEdit.Model
{
    public static class StringExtension
    {
        public static string GetMailList(this string str)
        {
            Regex reg = new Regex(@"[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}", RegexOptions.IgnoreCase);
            Match match;
            string resultText = string.Empty;

            List<string> results = new List<string>();
            for (match = reg.Match(str); match.Success; match = match.NextMatch())
            {
                if (!(results.Contains(match.Value)))
                {
                    results.Add(match.Value);
                    resultText += match.Value + "\n";
                }
            }
            return resultText;
        }

        public static string GetWordList(this string serchText, int wordLenght, string additionalFilter)
        {
            string resultText = string.Empty;

            char[] delimiterChars = { ' ', ',', '.', '<', '>', '!', '?', '(', ')', '-', '_', ':', '\t', '\n', '\r' };
            char[] charFiler = additionalFilter.ToCharArray();
            string[] words = serchText.Split(delimiterChars);
            

            foreach (var word in words)
            {
                if (charFiler.Length > 0)
                {
                    if (word.Length > wordLenght && word.IndexOfAny(charFiler) != -1)resultText += word + " ";
                }
                else
                {
                    if (word.Length > wordLenght) resultText += word + " ";
                }
            }

            return resultText;
        }
    }
}
