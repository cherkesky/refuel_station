using System.Collections.Generic;

namespace refuel_station
{
  class Program
  {
    static void Main(string[] args)
    {

      Zero fxs = new Zero();
      Zero fx = new Zero();
      Tesla modelS = new Tesla();
      List<IElectricPowered> electricVehicles = new List<IElectricPowered>();

      electricVehicles.Add(fx);
      electricVehicles.Add(fxs);
      electricVehicles.Add(modelS);

      Ram ram = new Ram();
      Cessna cessna150 = new Cessna();
      List<IGasPowered> gasVehicles = new List<IGasPowered>() {
                ram, cessna150
            };

      GasStation nashvilleGas = new GasStation(){Capacity=3};
      BatteryStation nashvilleBattery = new BatteryStation(){Capacity=3};


    }
  }
}
