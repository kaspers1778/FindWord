using System;

namespace FindWord
{
    
    static class Generator
    {
        static Random rand = new Random();

        private static string[] letters = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        
        public static string GenerateWord(int length)
        {
            string word = "";
            for (int i = 0; i < length; i++)
            {
                word += letters[rand.Next(0, letters.Length - 1)];
            }
            return word;
        }

    }
}
