using System;

namespace OOP_lab_3_7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; ++i)
            {
                int k = words[i].Length;
                for (int j = 0; j < words[i].Length; ++j)
                {
                    if ((words[i][j] == 'A') || (words[i][j] == 'E') || (words[i][j] == 'I') || (words[i][j] == 'O') || (words[i][j] == 'U') || (words[i][j] == 'Y')) --k;
                    if ((words[i][j] == 'a') || (words[i][j] == 'e') || (words[i][j] == 'i') || (words[i][j] == 'o') || (words[i][j] == 'u') || (words[i][j] == 'y')) --k;
                    if ((words[i][j] == 'А') || (words[i][j] == 'О') || (words[i][j] == 'У') || (words[i][j] == 'И') || (words[i][j] == 'І') || (words[i][j] == 'Е') || (words[i][j] == 'Я') || (words[i][j] == 'Ю') || (words[i][j] == 'Є') || (words[i][j] == 'Ї')) --k;
                    if ((words[i][j] == 'а') || (words[i][j] == 'о') || (words[i][j] == 'у') || (words[i][j] == 'и') || (words[i][j] == 'і') || (words[i][j] == 'е') || (words[i][j] == 'я') || (words[i][j] == 'ю') || (words[i][j] == 'є') || (words[i][j] == 'ї')) --k;
                }
                if (k % 2 != 0)
                {
                    words[i] = words[i].Remove(0);
                }
            }

            for (int i = 0; i < words.Length; ++i)
            {
                if (!String.IsNullOrWhiteSpace(words[i]))
                {
                    int k = 0;

                    for (int j = 0; j < words[i].Length; ++j)
                    {
                        if (words[i][j] == words[i][words[i].Length - j - 1])
                        {
                            ++k;
                        }
                    }
                        if(k % words[i].Length == 0)
                        {
                            words[i] = words[i].Remove(0);
                        }
                } 
            }
            
            for (int i = 0; i < words.Length; ++i)
            {
                if (!String.IsNullOrWhiteSpace(words[i]))
                {
                    Console.WriteLine("{0} ",words[i]);
                }
            }
        }
    }
}
