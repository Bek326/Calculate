namespace Calculate;

public static class ShapeAreaCalculator
{
    public static double CalculateArea(IShape shape)
    {
        if (shape == null)
            throw new ArgumentNullException(nameof(shape));

        return shape.CalculateArea();
    }
}