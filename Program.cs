using System.Collections.Generic;

namespace refuel_station
{
  class Program
  {
    static void Main(string[] args)
    {

      Zero fxs = new Zero(){Name="FXS"};
      Zero fx = new Zero(){Name="FX"};
      Tesla modelS = new Tesla(){Name="MODEL S"};
      List<IElectricPowered> electricVehicles = new List<IElectricPowered>();

      electricVehicles.Add(fx);
      electricVehicles.Add(fxs);
      electricVehicles.Add(modelS);

      Ram ram = new Ram(){Name="Ram"};
      Cessna cessna150 = new Cessna(){Name="Cessna150"};
      List<IGasPowered> gasVehicles = new List<IGasPowered>() {
                ram, cessna150
            };

      GasStation nashvilleGas = new GasStation() { Capacity = 3 };
      BatteryStation nashvilleBattery = new BatteryStation() { Capacity = 3 };


      nashvilleBattery.Refuel(electricVehicles);
      nashvilleGas.Refuel(gasVehicles);

    }
  }
}
