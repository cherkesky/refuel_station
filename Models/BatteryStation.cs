using System.Collections.Generic;

namespace refuel_station
{
  public class BatteryStation : IRefuelingStation<IElectricPowered>
  {
    public int Capacity { get; set; }

    public void Refuel(List<IElectricPowered> ep)
    {

    }

  }
}