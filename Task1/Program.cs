var cir = new Circle(3, "blue");
System.Console.WriteLine(cir.GetRadius());
cir.SetRadius(4);
System.Console.WriteLine(cir.GetColor());
cir.SetColor("yellow");
System.Console.WriteLine(cir.ToString());
System.Console.WriteLine(cir.GetArea());

System.Console.WriteLine("Cylinder");
var cyl=new Cylinder(1, 1, "green");
System.Console.WriteLine(cyl.GetHeight());
cyl.SetHeight(1);
System.Console.WriteLine(cyl.ToString());
System.Console.WriteLine(cyl.GetVolume());