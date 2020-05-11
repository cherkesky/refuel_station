namespace refuel_station {
    public class Zero : IElectricPowered {
        public double BatteryKWh { get; set; }
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        public void ChargeBattery () { System.Console.WriteLine("ZERO - Zoink!"); }
    }
}