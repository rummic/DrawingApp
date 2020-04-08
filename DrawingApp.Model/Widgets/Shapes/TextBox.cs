using System.Drawing;

namespace DrawingApp.Model.Widgets.Shapes
{
    public class TextBox : Rectangle
    {
        public Color BackgroundColor { get; set; }
        public string Text { get; set; }

        public TextBox(string name, int x, int y, int size, int height, int width, Color backgroundColor, string text)
            : base(name, x, y, size, height, width)
        {
            BackgroundColor = backgroundColor;
            Text = text;
        }

        internal override string Draw()
        {
            bool isTextEmpty = string.IsNullOrEmpty(Text);
            var backgroundColorToDraw = isTextEmpty ? Color.Red : BackgroundColor;
            return $"Name: {Name}, Size: {Size}, Height: {Height}, Width: {Width}, X: {X}, Y: {Y}, Background Color: {backgroundColorToDraw}, Text: {Text}";
        }
    }
}