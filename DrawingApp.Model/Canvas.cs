using DrawingApp.Model.Widgets;
using System;
using System.Collections.Generic;

namespace DrawingApp.Model
{
    public class Canvas
    {
        private readonly HashSet<Widget> _widgets = new HashSet<Widget>();

        public void AddWidget(Widget widget)
        {
            if (_widgets.Contains(widget))
            {
                throw new ArgumentException($"Widget with name \"{widget.Name}\" already exists.");
            }

            _widgets.Add(widget);
        }
        public void AddWidgets(IEnumerable<Widget> widgets)
        {
            foreach (var widget in widgets)
            {
                AddWidget(widget);
            }
        }

        public void Print()
        {
            foreach (var widget in _widgets)
            {
                Console.WriteLine(widget.Draw());
            }
        }

    }
}
