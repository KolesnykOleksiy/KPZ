namespace Bridge;

public class Raster
{
    protected IFigure _figure;

    public Raster(IFigure figure)
    {
        _figure = figure;
    }

    public void DrawRasterFigure()
    {
        Console.WriteLine($"{_figure.DrawFigure()} in raster format");
    }
}