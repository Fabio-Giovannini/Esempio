using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Text;
using System.Runtime.Serialization;
using System.Formats.Tar;
using Microsoft.VisualBasic;

namespace BlaisePascal.Esempio.Domain
{
    /// <summary>
    /// Ogni veicolo è caratterizzato da:
    /// Una targa(LicensePlate)
    /// Il chilometraggio attuale(OdometerKm)
    /// La tariffa giornaliera di noleggio(DailyRate)
    /// Il livello percentuale di carburante nel serbatoio(FuelLevelPercentage)
    /// Il Modello deve:
    /// Impedire la creazione di veicoli con valori incoerenti(es.targa non valida, chilometri o tariffe negative).
    /// Permetta di registrare i viaggi effettuati, incrementando il chilometraggio e riducendo il carburante residuo.
    /// Consentire di effettuare il rifornimento fino a un massimo del 100 % della capienza del serbatoio.
    /// </summary>
    public class Vehicle
    {
        private int _odoneterKm;
        private double _dailyRate;
        private double _fuelLevelPercentage;


        public string LicensePlate { get; private set; }
        public int OdometerKm 
        {
            get 
            {  return _odoneterKm; }
            private set
            {
                if (value < 0) throw new ArgumentException($"value not allowd{nameof(OdometerKm)}: {value}");

                _odoneterKm = value;
            } 
        }
        public double DailyRate { get;  private set; }
        public double FuellLevelPercentage {  get; private set; }

        /// <summary>
        /// metodo costruttore che inizializza la targa del veicolo
        /// </summary>
        /// <param name="licensePlate"></param>
        public Vehicle(string licencePlate)
        {
            //TODO: Validazione della targa
            LicensePlate = licencePlate;//chiamata ad un set
        }

        /*
        /// <summary>
        /// metodo costruttore che inizializza la targa del veicolo, il contachilometri, il prezzo giornaliero e il livello di carburante
        /// </summary>
        /// <param name="licensePlate"></param>
        /// <param name="odometerKm"></param>
        /// <param name="dailyRate"></param>
        /// <param name="fuelLevelPercentage"></param>*/
        
        public Vehicle(string licencePlate, int odemtertKm, double dailyRate, double fuelPercentage) 
        {
            LicensePlate = licencePlate;
            OdometerKm = odemtertKm;
            DailyRate = dailyRate;
            FuellLevelPercentage = fuelPercentage;
        }

    }
}
