using System.Collections.Generic;

namespace refuel_station
{
  public class BatteryStation : IRefuelingStation<IElectricPowered>
  {
    public int Capacity { get; set; }

    public void Refuel(List<IElectricPowered> ep)
    {
      foreach (var vehicle in ep){
        System.Console.WriteLine($"The {vehicle.Name} refueled with 200 KW of electricity");
      }
    }

  }
}