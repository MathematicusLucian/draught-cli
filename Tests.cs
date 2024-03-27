using NUnit.Framework;
using NUnit.Framework.Legacy;
using draught_cli;

namespace draught_cli.Tests
{
    [TestFixture]
    public class WidgetTests
    {
        [Test]
        public void CreateRectangle_ShouldNotBeNull()
        {
            // Arrange & Act
            Rectangle rectangle = new Rectangle { X = 0, Y = 0, Width = 10, Height = 20 };
            
            // Assert
            ClassicAssert.IsNotNull(rectangle);
        }

        [Test]
        public void RectangleDraw_ShouldReturnExpectedString()
        {
            // Arrange
            Rectangle rectangle = new Rectangle { X = 10, Y = 10, Width = 30, Height = 40 };
            
            // Act
            string result = rectangle.Draw();
            
            // Assert
            ClassicAssert.AreEqual("Rectangle (10,10) width=30 height=40", result);
        }

        [Test]
        public void CreateSquare_ShouldNotBeNull()
        {
            // Arrange & Act
            Square square = new Square { X = 0, Y = 0, Size = 15 };
            
            // Assert
            ClassicAssert.IsNotNull(square);
        }

        [Test]
        public void SquareDraw_ShouldReturnExpectedString()
        {
            // Arrange
            Square square = new Square { X = 0, Y = 0, Size = 15 };
            
            // Act
            string result = square.Draw();
            
            // Assert
            ClassicAssert.AreEqual("Square (0,0) size=15", result);
        }
    }
}
