namespace DrawingApp.Model.Widgets.Shapes
{
    public class Ellipse : Widget
    {
        public int VerticalDiameter { get; set; }
        public int HorizontalDiameter { get; set; }
        public Ellipse(string name, int x, int y, int size, int verticalDiameter, int horizontalDiameter)
            : base(name, x, y, size)
        {
            VerticalDiameter = verticalDiameter;
            HorizontalDiameter = horizontalDiameter;
        }

        internal override string Draw()
        {
            return $"Name: {Name}, Size: {Size}, Vertical Diameter: {VerticalDiameter}, Horizontal Diameter: {HorizontalDiameter}, X: {X}, Y: {Y}";
        }
    }
}