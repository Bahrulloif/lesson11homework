interface IVehicle
{
    public int Gasoline { get; set; }
    public void Drive();

    public bool Refuel(int gasoline);

}