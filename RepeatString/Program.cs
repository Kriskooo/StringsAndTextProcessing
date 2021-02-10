using System;

namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] word = Console.ReadLine().Split();
            for (int i = 0; i < word.Length; i++)
            {
                for (int k = 0; k < word[i].Length; k++)
                {
                    Console.Write(word[i]);
                }
            }
        }
    }
}
