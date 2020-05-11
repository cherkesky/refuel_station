namespace refuel_station
{
  public class Tesla : IElectricPowered
  {
    public string Name { get; set; }
    public double BatteryKWh { get; set; }
    public string MainColor { get; set; }
    public string MaximumOccupancy { get; set; }

    public void ChargeBattery() { System.Console.WriteLine("TESLA - Zoink!"); }
  }
}