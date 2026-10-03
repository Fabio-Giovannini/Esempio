using System;
using System.Collections.Generic;
using System.Text;

namespace BlaisePascal.Esempio.Domain
{
    public class Vehicle
    {
        public string LicensePlate { get; private set; }
        public int OdometerKm {
            get {  return OdometerKm; }
            private set; }
        public double DailyRate { get;  private set; }
        public double FuellLevelPercentage {  get; private set; }

        public Vehicle(string licencePlate)
        {
            LicensePlate = licencePlate;//chiamata ad un set
        }

        public Vehicle(string licencePlate, int odemtertKm, double dailyRate, double fuelPercentage) 
        {
        }

    }
}
