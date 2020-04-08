namespace DrawingApp.Model.Widgets.Shapes
{
    public class Circle : Widget
    {
        public Circle(string name, int x, int y, int size)
            : base(name, x, y, size)
        {
        }

        internal override string Draw()
        {
            return $"Name: {Name}, Size: {Size}, X: {X}, Y: {Y}";
        }
    }
}