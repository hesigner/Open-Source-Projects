﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Code_Seperator
{
    
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Environment.UserName;

            Console.WriteLine("Past the Material file to the Desktop and change the file name to Getme ");
            Console.WriteLine("Press Enter When Done!");
            Console.ReadLine();
            string fileText=" ";

            try
            {
                 fileText = System.IO.File.ReadAllText(@"C:\\Users\\" + userName + "\\Desktop\\Getme.txt");
            }
            catch (Exception)
            {
                Console.WriteLine("Error While Loading File !");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("File has been loaded Sucessfully");
            Console.WriteLine("");

            Console.WriteLine("Create Text File");
            Console.Write("File Name: ");
            string savelocation = Console.ReadLine();
            Console.Write("");
            string filelocation = @"C:\\Users\\" + userName + "\\Desktop\\" + savelocation + ".txt";

            int length = 7;

            String line = fileText;
            String[] words = line.Split(new[] { " " }, StringSplitOptions.None);
            StreamWriter sw = new StreamWriter(filelocation);
            sw.WriteLine("**************");

            foreach (String str in words)
            {
                if (str.Length > length)
                {
                    if (Regex.IsMatch(str, @"^[A-Z0-9]*$"))
                    {
                        if (Regex.IsMatch(str, @"^[A-Z]*$"))
                        {  
                        }
                        else
                        {
                            sw.WriteLine(str);
                        }  
                    }
                }
            }
            sw.WriteLine("**************");
            sw.Close();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Your Data has been Extracted Sucessfully !");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Read();
        }
    }   
}
