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
        private int width;
        private int height;

        public int Width 
        { 
            get => width;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Width cannot be negative");
                
                width = value;
            }
        }

        public int Height
        {
            get => height;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Height cannot be negative");

                height = value;
            }
        }

        public override string Draw()
        {
            return $"Rectangle ({X},{Y}) width={Width} height={Height}";
        }
    }

    public class Square : Widget
    {
        private int size;

        public int Size 
        { 
            get => size;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Size cannot be negative");
                
                size = value;
            }
        }

        public override string Draw()
        {
            return $"Square ({X},{Y}) size={Size}";
        }
    }

    public class Ellipse : Widget
    {
        private int diameterH;
        private int diameterV;

        public int DiameterH 
        { 
            get => diameterH;
            set
            {
                if (value < 0)
                    throw new ArgumentException("DiameterH cannot be negative");
                
                diameterH = value;
            }
        }

        public int DiameterV
        {
            get => diameterV;
            set
            {
                if (value < 0)
                    throw new ArgumentException("DiameterV cannot be negative");

                diameterV = value;
            }
        }

        public override string Draw()
        {
            return $"Ellipse ({X},{Y}) diameterH={DiameterH} diameterV={DiameterV}";
        }
    }

    public class Circle : Widget
    {
        private int size;

        public int Size 
        { 
            get => size;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Size cannot be negative");
                
                size = value;
            }
        }

        public override string Draw()
        {
            return $"Circle ({X},{Y}) size={Size}";
        }
    }

    public class Textbox : Widget
    {
        private int width;
        private int height;
        private string? text;

        public int Width 
        { 
            get => width;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Width cannot be negative");
                
                width = value;
            }
        }
        
        public int Height 
        { 
            get => height;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Height cannot be negative");
                
                height = value;
            }
        }

        public string? Text 
        { 
            get => text;
            set
            {
                if (value == "")
                    throw new ArgumentException("Text cannot be empty");
                
                text = value;
            }
        }

        public override string Draw()
        {
            return $"Textbox ({X},{Y}) width={Width} height={Height} Text=\"{Text}\"";
        }
    }
}
