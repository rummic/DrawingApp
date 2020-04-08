# DrawingApp

Console application made for recruitment process.

Solution consists of 3 projects:
- CLI
- Model
- Tests

Model contains Widgets and Canvas classes.
Tests project is for unit tests.

Assumptions:
- Widgets are immutable.
- Widgets cannot be deleted from canvas.
- Widget Draw method is internal, called by Canvas Print method.
- Widget name must be unique so there cannot be two shapes with the same name added to the canvas. 
- Canvas prints straight to Console.
- TextBox Draw method only returns red colour when there is missing text value and does not change colour value held by BackgroundColor variable.
