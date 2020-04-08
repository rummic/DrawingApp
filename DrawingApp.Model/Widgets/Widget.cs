namespace DrawingApp.Model.Widgets
{
    public abstract class Widget
    {
        protected Widget(string name, int x, int y, int size)
        {
            Name = name;
            X = x;
            Y = y;
            Size = size;
        }
        public string Name { get; }
        public int X { get; }
        public int Y { get; }
        public int Size { get; }

        internal abstract string Draw();

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (obj is Widget widget)
            {
                return Name == widget.Name;
            }

            return base.Equals(obj);
        }
    }
}
