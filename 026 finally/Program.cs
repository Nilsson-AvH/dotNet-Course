// See https://aka.ms/new-console-template for more information
using System;

namespace ejemplofinally
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader file = null;

            try
            {
                string line;

                int cont = 0;

                string path = @"D:\Users\NilssonAvH\Desktop\muere.txt";

                file = new System.IO.StreamReader(path);

                while ((line = file.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    cont++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("File read error.");
            }
            finally
            {
                if(file != null) file.Close();
                Console.WriteLine("File connection closed.");
            }
        }
    }
}