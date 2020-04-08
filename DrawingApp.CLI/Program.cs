using System;
using System.Collections.Generic;
using DrawingApp.Model;
using DrawingApp.Model.Widgets;
using DrawingApp.Model.Widgets.Shapes;
using Color = System.Drawing.Color;

namespace DrawingApp.CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            Widget square = new Square(name: "square1", x: 1, y: 1, size: 3);
            Widget rectangle = new Rectangle(name: "rectangle1", x: 1, y: 1, size: 10, height: 2, width: 5);
            Widget circle = new Circle(name: "circle1", x: 1, y: 1, size: 3);
            Widget ellipse = new Ellipse(name: "ellipse1", x: 1, y: 1, size: 8, verticalDiameter: 3, horizontalDiameter: 3);
            Widget textBox = new TextBox(name: "textBox1", x: 1, y: 1, size: 10, height: 2, width: 5, backgroundColor: Color.Blue, text: "TextBox1 text.");
            Widget textBoxRed = new TextBox(name: "textBox1red", x: 1, y: 1, size: 10, height: 2, width: 5, backgroundColor: Color.Blue, text: "");

            var widgetsList = new List<Widget>
            {
                new Square(name: "square2", x: 1, y: 1, size: 3),
                new Rectangle(name: "rectangle2", x: 1, y: 1, size: 10, height: 2, width: 5),
                new Circle(name: "circle2", x: 1, y: 1, size: 3),
                new Ellipse(name: "ellipse2", x: 1, y: 1, size: 8, verticalDiameter: 3, horizontalDiameter: 3),
                new TextBox(name: "textBox2", x: 1, y: 1, size: 10, height: 2, width: 5, backgroundColor: Color.Blue, text: "TextBox2 text."),
                new TextBox(name: "textBox2red", x: 1, y: 1, size: 10, height: 2, width: 5, backgroundColor: Color.Blue, text: "")
            };

            Canvas canvas = new Canvas();

            canvas.AddWidget(square);
            canvas.AddWidget(rectangle);
            canvas.AddWidget(circle);
            canvas.AddWidget(ellipse);
            canvas.AddWidget(textBox);
            canvas.AddWidget(textBoxRed);
            canvas.Print();

            Console.WriteLine("=================================");

            canvas.AddWidgets(widgetsList);
            canvas.Print();

        }
    }
}
