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
            ClassicAssert.AreEqual("Rectangle (10,10) width=30 height=40", result);
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
            ClassicAssert.AreEqual("Square (0,0) size=15", result);
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
            ClassicAssert.AreEqual("Ellipse (0,0) diameterH=30 diameterV=20", result);
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
            ClassicAssert.AreEqual("Circle (0,0) size=25", result);
        }
    }
}
