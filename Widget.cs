using System;

namespace draught_cli
{
    // Interface for all drawable objects
    public interface IDrawable
    {
        string Draw();
    }

    // Base class for all widgets
    public abstract class Widget : IDrawable
    {
        public int X { get; set; }
        public int Y { get; set; }

        public abstract string Draw();
    }

    public class Rectangle : Widget
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public override string Draw()
        {
            return $"Rectangle ({X},{Y}) width={Width} height={Height}";
        }
    }

    public class Square : Widget
    {
        public int Size { get; set; }

        public override string Draw()
        {
            return $"Square ({X},{Y}) size={Size}";
        }
    }

    public class Ellipse : Widget
    {
        public int DiameterH { get; set; }
        public int DiameterV { get; set; }

        public override string Draw()
        {
            return $"Ellipse ({X},{Y}) diameterH={DiameterH} diameterV={DiameterV}";
        }
    }

    public class Circle : Widget
    {
        public int Size { get; set; }

        public override string Draw()
        {
            return $"Circle ({X},{Y}) size={Size}";
        }
    }

    public class Textbox : Widget
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public string? Text { get; set; }

        public override string Draw()
        {
            return $"Textbox ({X},{Y}) width={Width} height={Height} Text=\"{Text}\"";
        }
    }
}
