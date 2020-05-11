using System.Collections.Generic;

namespace refuel_station
{
  public class GasStation : IRefuelingStation<IGasPowered>
  {

    public int Capacity { get; set; }
    public void Refuel(List<IGasPowered> gp)
    {

      foreach (IGasPowered vehicle in gp)
      {
        System.Console.WriteLine($"The {vehicle.Name} refueled with 200 gallons of gas");

      }

    }
  }
}