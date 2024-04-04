namespace Bridge;

public class Vector
{
    protected IFigure _figure;

    public Vector(IFigure figure)
    {
        _figure = figure;
    }

    public void DrawVectorFigure()
    {
        Console.WriteLine($"{_figure.DrawFigure()} in vector format");
    }
}