public class Cylinder : Circle
{
    private double _height = 1.0;

    public Cylinder()
    {

    }
    public Cylinder(double height)
    {
        _height = height;
    }
    public Cylinder(double height, double radius) : base(radius)
    {

    }
    public Cylinder(double height, double radius, string color) : base(radius, color)
    {

    }
    public double GetHeight()
    {
        return _height;
    }
    public void SetHeight(double height)
    {
        _height = height;
    }
    public override string ToString()
    {
        return base.ToString();
    }
    public double GetVolume(){
        return GetArea()*_height;
    }
}