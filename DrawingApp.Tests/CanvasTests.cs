using DrawingApp.Model;
using DrawingApp.Model.Widgets;
using DrawingApp.Model.Widgets.Shapes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using Color = System.Drawing.Color;

namespace DrawingApp.Tests
{
    public class CanvasTests
    {
        [Test]
        public void AddingDuplicateWidget_ShouldThrowException()
        {
            //Arrange
            var canvas = new Canvas();
            Widget square = new Square(name: "square1", x: 1, y: 1, size: 3);
            Widget squareDuplicate = new Square(name: "square1", x: 2, y: 2, size: 4);
            canvas.AddWidget(square);

            //Act & Assert
            Assert.Throws<ArgumentException>(() => canvas.AddWidget(squareDuplicate));
        }

        [Test]
        public void AddingSameWidgetTwice_ShouldThrowException()
        {
            //Arrange
            var canvas = new Canvas();
            Widget square = new Square(name: "square1", x: 1, y: 1, size: 3);
            canvas.AddWidget(square);

            //Act & Assert
            Assert.Throws<ArgumentException>(() => canvas.AddWidget(square));
        }

        [Test]
        public void PrintingTextBoxWithoutText_ShouldPrintRedBackgroundColor()
        {
            //Arrange
            var canvas = new Canvas();
            var textBox = new TextBox(name: "textBox", x: 1, y: 1, size: 3, height: 2, width: 10, Color.AliceBlue, "");
            canvas.AddWidget(textBox);
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            //Act
            canvas.Print();

            //Assert
            var expected = "Name: textBox, Size: 3, Height: 2, Width: 10, X: 1, Y: 1, Background Color: Color [Red], Text: \r\n";
            Assert.AreEqual(expected, stringWriter.ToString());
        }

        [Test]
        public void PrintingTextBoxWithText_ShouldPrintProperBackgroundColor()
        {
            //Arrange
            var canvas = new Canvas();
            var textBox = new TextBox(name: "textBox", x: 1, y: 1, size: 3, height: 2, width: 10, Color.AliceBlue, "Test");
            canvas.AddWidget(textBox);
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            //Act
            canvas.Print();

            //Assert
            var expected = "Name: textBox, Size: 3, Height: 2, Width: 10, X: 1, Y: 1, Background Color: Color [AliceBlue], Text: Test\r\n";
            Assert.AreEqual(expected, stringWriter.ToString());
        }

        [Test]
        public void PrintingWidgets_ShouldPrintProperString()
        {
            //Arrange
            var canvas = new Canvas();
            var widgetsList = new List<Widget>
            {
                new Square(name: "square2", x: 1, y: 1, size: 3),
                new Rectangle(name: "rectangle2", x: 1, y: 1, size: 10, height: 2, width: 5),
                new Circle(name: "circle2", x: 1, y: 1, size: 3),
                new Ellipse(name: "ellipse2", x: 1, y: 1, size: 8, verticalDiameter: 3, horizontalDiameter: 3),
                new TextBox(name: "textBox2", x: 1, y: 1, size: 10, height: 2, width: 5, backgroundColor: Color.Blue,
                    text: "TextBox2 text."),
                new TextBox(name: "textBox2red", x: 1, y: 1, size: 10, height: 2, width: 5, backgroundColor: Color.Blue,
                    text: "")
            };
            canvas.AddWidgets(widgetsList);
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            //Act
            canvas.Print();

            var expected =
                "Name: square2, Size: 3, X: 1, Y: 1\r\n" +
                "Name: rectangle2, Size: 10, Height: 2, Width: 5, X: 1, Y: 1\r\n" +
                "Name: circle2, Size: 3, X: 1, Y: 1\r\n" +
                "Name: ellipse2, Size: 8, Vertical Diameter: 3, Horizontal Diameter: 3, X: 1, Y: 1\r\n" +
                "Name: textBox2, Size: 10, Height: 2, Width: 5, X: 1, Y: 1, Background Color: Color [Blue], Text: TextBox2 text.\r\n" +
                "Name: textBox2red, Size: 10, Height: 2, Width: 5, X: 1, Y: 1, Background Color: Color [Red], Text: \r\n";

            //Assert
            Assert.AreEqual(expected, stringWriter.ToString());
        }
    }
}
