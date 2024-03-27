using NUnit.Framework;
using NUnit.Framework.Legacy;
using draught_cli;

namespace draught_cli.Tests
{
    [TestFixture]
    public class WidgetTests
    {
        [Test]
        public void Rectangle_Init_ShouldNotBeNull()
        {
            // Arrange & Act
            Rectangle rectangle = new Rectangle { X = 0, Y = 0, Width = 10, Height = 20 };
            
            // Assert
            ClassicAssert.IsNotNull(rectangle);
        }

        [Test]
        public void Rectangle_Draw_ShouldReturnExpectedString()
        {
            // Arrange
            Rectangle rectangle = new Rectangle { X = 10, Y = 10, Width = 30, Height = 40 };
            
            // Act
            string result = rectangle.Draw();
            
            // Assert
            string expected = "Rectangle (10,10) width=30 height=40";
            ClassicAssert.AreEqual(expected, result);
        }

        [Test]
        public void Square_Init_ShouldNotBeNull()
        {
            // Arrange & Act
            Square square = new Square { X = 0, Y = 0, Size = 15 };
            
            // Assert
            ClassicAssert.IsNotNull(square);
        }

        [Test]
        public void Square_Draw_ShouldReturnExpectedString()
        {
            // Arrange
            Square square = new Square { X = 0, Y = 0, Size = 15 };
            
            // Act
            string result = square.Draw();
            
            // Assert
            string expected = "Square (0,0) size=15";
            ClassicAssert.AreEqual(expected, result);
        }

        [Test]
        public void Ellipse_Init_ShouldNotBeNull()
        {
            // Arrange & Act
            Ellipse ellipse = new Ellipse { X = 0, Y = 0, DiameterH = 30, DiameterV = 20 };
            
            // Assert
            ClassicAssert.IsNotNull(ellipse);
        }

        [Test]
        public void Ellipse_Draw_ShouldReturnExpectedString()
        {
            // Arrange
            Ellipse ellipse = new Ellipse { X = 0, Y = 0, DiameterH = 30, DiameterV = 20 };

            // Act
            string result = ellipse.Draw();
            
            // Assert
            string expected = "Ellipse (0,0) diameterH=30 diameterV=20";
            ClassicAssert.AreEqual(expected, result);
        }

        [Test]
        public void Circle_Init_ShouldNotBeNull()
        {
            // Arrange & Act
            Circle circle = new Circle { X = 0, Y = 0, Size = 25 };
            
            // Assert
            ClassicAssert.IsNotNull(circle);
        }

        [Test]
        public void Circle_Draw_ShouldReturnExpectedString()
        {
            // Arrange
            Circle circle = new Circle { X = 0, Y = 0, Size = 25 };

            // Act
            string result = circle.Draw();
            
            // Assert
            string expected = "Circle (0,0) size=25";
            ClassicAssert.AreEqual(expected, result);
        }

        [Test]
        public void Textbox_Init_ShouldNotBeNull()
        {
            // Arrange & Act
            Textbox textbox = new Textbox { X = 0, Y = 0, Width = 50, Height = 30, Text = "Lorem ipsum" };
            
            // Assert
            ClassicAssert.IsNotNull(textbox);
        }

        [Test]
        public void Textbox_Draw_ShouldReturnExpectedString()
        {
            // Arrange
            Textbox textbox = new Textbox { X = 0, Y = 0, Width = 50, Height = 30, Text = "Lorem ipsum" };

            // Act
            string result = textbox.Draw();
            
            // Assert
            string expected = "Textbox (0,0) width=50 height=30 Text=\"Lorem ipsum\"";
            ClassicAssert.AreEqual(expected, result);
        }
    }

    [TestFixture]
    public class DraughtEngineTests
    {
        [Test]
        public void AddOneWidget_ShouldReturnOneWidget()
        {
            // Arrange
            DraughtEngine drawing = new DraughtEngine();

            // Act
            drawing.AddWidget(new Rectangle { X = 10, Y = 10, Width = 30, Height = 40 });
            var result = drawing.GetWidgets().Count;

            // Assert
            int expected = 1;
            ClassicAssert.AreEqual(expected, result);
        }

        [Test]
        public void AddTwoWidget_ShouldReturnTwoWidgets()
        {
            // Arrange
            DraughtEngine drawing = new DraughtEngine();

            // Act
            drawing.AddWidget(new Rectangle { X = 10, Y = 10, Width = 30, Height = 40 });
            drawing.AddWidget(new Circle { X = 0, Y = 0, Size = 25 });
            var result = drawing.GetWidgets().Count;

            // Assert
            int expected = 2;
            ClassicAssert.AreEqual(expected, result);
        }

        [Test]
        public void AddRectangle_ShouldReturnRectangle()
        {
            // Arrange
            DraughtEngine drawing = new DraughtEngine();

            // Act
            drawing.AddWidget(new Rectangle { X = 10, Y = 10, Width = 30, Height = 40 });
            var result = drawing.GetWidgets()[0].ToString();

            // Assert
            string expected = "draught_cli.Rectangle";
            ClassicAssert.AreEqual(expected, result);
        }
    }
}
