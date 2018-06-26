using System;

namespace Algos.Lib
{
    public class Strings 
    {
        public static bool PalindromePermutation(string s)
        {
            int CharNumber(char c)
            {
                if (c < 'a' || c > 'z')
                    return -1;

                return c - 'a';
            }

            int mask = 0;

            void Toggle(int n)
            {
                if (n < 0)
                    return;
                
                int i = 1;
                var m = i << n;

                if ((mask & m) > 0)
                {
                    mask = mask & ~m;
                }
                else
                {
                    mask = mask | m;
                }
                
            }
            
            foreach( char c in s )
            {
                Toggle(CharNumber(c));
            }

            return (mask & (mask - 1)) == 0;
        }
    }
}