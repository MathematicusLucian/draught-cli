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
    }
}
