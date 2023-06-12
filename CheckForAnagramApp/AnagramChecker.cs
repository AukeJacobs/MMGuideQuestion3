namespace CheckForAnagramApp
{
    public class AnagramChecker
    {
        public static bool AreAnagram(string firstString, string secondString)
        {
            var charArrayFirstString = firstString.ToCharArray();
            var charArraysecondString = secondString.ToCharArray();

            Array.Sort(charArrayFirstString);
            Array.Sort(charArraysecondString);

            return charArrayFirstString.SequenceEqual(charArraysecondString);
        }

        public static bool AreAnagramNoSort(string firstString, string secondString)
        {
            if (firstString.Length != secondString.Length)
                return false;

            var characterCount = new Dictionary<char, int>();

            foreach (var character in firstString)
            {
                if (characterCount.ContainsKey(character))
                {
                    characterCount[character]++;
                }
                else
                {
                    characterCount.Add(character, 1);
                }
            }

            foreach (var character in secondString)
            {
                if (characterCount.ContainsKey(character))
                {
                    characterCount[character]--;
                }
                else
                {
                    return false;
                }
            }

            return !characterCount.Values.Any(c => c > 0);
        }
    }
}