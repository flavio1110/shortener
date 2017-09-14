using System;
using System.Linq;

namespace Shortner.Web.Data
{
    public static class ShortenerCore
    {
        private static readonly string Alphabet = 
            "aA1bB2cC3dD4eE5fF6gG7hH9iIjJkKlLmMnNoOpPqQrRsStTuUvVwWxXyYzZ";
        private static readonly int Base = Alphabet.Length / 2;

        public static string Encode(int i)
        {
            if (i == 0) return Alphabet[0].ToString();

            var s = string.Empty;

            while (i > 0)
            {
                s += Alphabet[i % Base];
                i = i / Base;
            }

            return string.Join(string.Empty, s.Reverse());
        }

        public static int Decode(string s)
        {
            var i = 0;

            foreach (var c in s)
                i = (i * Base) + Alphabet.IndexOf(c);

            return i;
        }
    }
}