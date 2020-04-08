namespace DrawingApp.Model.Widgets.Shapes
{
    public class Rectangle : Widget
    {
        public int Height { get; }
        public int Width { get; }
        public Rectangle(string name, int x, int y, int size, int height, int width)
            : base(name, x, y, size)
        {
            Height = height;
            Width = width;
        }

        internal override string Draw()
        {
            return $"Name: {Name}, Size: {Size}, Height: {Height}, Width: {Width}, X: {X}, Y: {Y}";
        }
    }
}