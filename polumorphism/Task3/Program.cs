var car = new Car(0);
System.Console.WriteLine("Enter amount of gasoline:");
int amount = Convert.ToInt32(Console.ReadLine());
car.Refuel(amount);
car.Drive();

