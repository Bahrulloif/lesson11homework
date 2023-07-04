public class Circle
{
    private double _radius = 1.0;
    private string _color = "red";

    public Circle()
    {

    }
    public Circle(double radius)
    {
        _radius = radius;
    }
    public Circle(double radius, string color)
    {
        _color = color;
        _radius = radius;
    }
    public double GetRadius()
    {
        return _radius;
    }
    public void SetRadius(double radius)
    {
        _radius = radius;
    }
    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }
    public virtual string ToString()
    {
        return "Privet";
    }
    public double GetArea()
    {
        return _radius * _radius * 3.14;
    }

}