using System;
using System.Collections.Generic;

namespace draught_cli
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Rectangle rectangle = new Rectangle { X = 10, Y = 10, Width = 30, Height = 40 };
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}