PointXY obj = new PointXY();
obj.X = 2121;





public readonly record struct Point(double X, double Y);


public record struct PointXY
{
    public PointXY()
    {
    }

    public PointXY(double x, double y)
    {
        X = x;
        Y = y;
    }

    public double X { get; init; } = 0;
    public double Y { get; init; } = 0;
}