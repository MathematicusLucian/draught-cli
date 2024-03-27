using System;
using System.Collections.Generic;

namespace draught_cli
{
    class Program
    {
        static void Main(string[] args)
        {
            DraughtEngine drawing = new DraughtEngine();

            try
            {
                // Adding widgets
                drawing.AddWidget(new Rectangle { X = 10, Y = 10, Width = 30, Height = 40 });
                drawing.AddWidget(new Square { X = 15, Y = 30, Size = 35 });
                drawing.AddWidget(new Ellipse { X = 100, Y = 150, DiameterH = 300, DiameterV = 200 });
                drawing.AddWidget(new Circle { X = 1, Y = 1, Size = 300 });
                drawing.AddWidget(new Textbox { X = 5, Y = 5, Width = 200, Height = 100, Text = "sample text" });
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            // Printing drawing
            drawing.PrintDrawing();
        }
    }
}