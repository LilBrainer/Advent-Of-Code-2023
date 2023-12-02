using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Metadata;

namespace Day1
{
    internal class Program
    {
        static void Main()
        {
            string firstNum = "";
            string currentNum = "";
            string total = "";
            int result = 0;


            string[] text = File.ReadAllLines("../../../input.txt");
            foreach (string line in text)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    char letter = line[i];
                    switch (letter)
                    {
                        case '0':
                        case '1':
                        case '2':
                        case '3':
                        case '4':
                        case '5':
                        case '6':
                        case '7':
                        case '8':
                        case '9':
                            if (firstNum == "")
                            {
                                firstNum = letter.ToString();
                            }else
                            {
                                currentNum = letter.ToString();
                            }
                            break;

                    }
                }
                if (currentNum == "")
                {
                    currentNum = firstNum;
                }
                string num = firstNum + currentNum;
                firstNum = "";
                currentNum = "";
                result += int.Parse(num);
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
