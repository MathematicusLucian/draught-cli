using System;
using System.Collections.Generic;

namespace draught_cli
{
    // Class to manage draught widgets
    public class DraughtEngine
    {
        private List<Widget> widgets = new List<Widget>();

        public void AddWidget(Widget widget)
        {
            widgets.Add(widget);
        }

        public void PrintDrawing()
        {
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Requested Drawing");
            Console.WriteLine("----------------------------------------------------------------");
            foreach (var widget in widgets)
            {
                Console.WriteLine(widget.Draw());
            }
            Console.WriteLine("----------------------------------------------------------------");
        }

        public List<Widget> GetWidgets()
        {
            return widgets;
        }
    }
}