interface IShape
{
    double Area { get; }
    double Permiter { get; }
}

internal class Square : IShape, IComparable<IShape>
{
    private double m_len;
    public Square(double len)
    {
        m_len = len;
    }

    public double Area => m_len * m_len;

    public double Permiter => m_len * 4;

    public int CompareTo(IShape? other)
    {
        return this.Area.CompareTo(other.Area);
    }
}

internal class Circle : IShape
{
    private double m_radius;
    public Circle(double radius)
    {
        m_radius = radius;
    }

    public double Area => Math.PI * m_radius * m_radius;

    public double Permiter => 2 * Math.PI * m_radius;
}

internal class Rectangle : IShape
{
    private double m_len;
    private double m_width;
    public Rectangle(double len, double width)
    {
        this.m_len = len;
        this.m_width = width;
    }

    public double Area => m_len * m_width;

    public double Permiter => 2 * (m_len + m_width);
}