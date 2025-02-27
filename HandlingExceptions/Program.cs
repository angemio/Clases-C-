﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText
                (@"C:\Users\Angel\Documents\Visual Studio 2022\Clases\Exampl.txt");
                Console.WriteLine(content);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine("Make sure the file name is named correctly: Example.txt");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine(@"Make sure the dictory c:\users\... exists");
            }
            catch (Exception ex)
            {
                Console.WriteLine("there was a problem");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //code to finalize
                //setting objects to null
                //closing database connections
                Console.WriteLine("Closing the app now...");
            }
            Console.ReadLine();
        }
    }
}
