using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {

            static void Main(string[] args)
            {
                string[] file;
                string[] file1;
                int student = 0;
                file = File.ReadAllLines("text.txt");
                for (int i = 0; i < file.Length; i++)
                {
                    file1 = file[i].Split(' ');
                    for (int j = 0; j < file1.Length; j++)
                        if (file1[j].Contains("STUDENT")) student++;

                }
                Console.WriteLine("STUDENT встречается " + student + " раз(а)");
                Console.ReadLine();
            }
        }
    }


