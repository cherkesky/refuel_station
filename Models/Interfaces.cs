using System.Collections.Generic;

namespace refuel_station {
  
    public interface IElectricPowered {
      string Name {get; set;}
        double BatteryKWh { get; set; }
        void ChargeBattery ();
    }

    public interface IGasPowered {  
      string Name {get; set;}
      double FuelCapacity  { get; set; }
      void RefuelTank();

    }
      public interface IRefuelingStation<T>
  {   

    //  The number of vehicles that they can refuel at any one time.
     int Capacity {get; set;}
     void Refuel(List<T> vehicles);
  } 
}