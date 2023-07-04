public class Dog: Animal{
    public override void Eat()
    {
       System.Console.WriteLine($"{base.Name} is Eating");
    }   
}