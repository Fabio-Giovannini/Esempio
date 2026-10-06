using BlaisePascal.Esempio.Domain;
using System;
using System.Collections.Generic;
using System.Text;
namespace BlaisePascal.Esempio.UIConsole
{
    public class Program // Questa è una classe
    {
        //Metodo di entrata per esecuzione del codice
        public static void Main(string[] args)
        {

            /*
            //Stampo a video il messaggio per chiedere il nome del cliente
            Console.WriteLine("Inserisci il nome del cliente");
            // Assegnamop il valore letto dal ReadLine() alla variabile
            string nomeCliente = Console.ReadLine();

            Console.WriteLine($"Benvenuto {nomeCliente} nella libreria Easy Library");

            Console.WriteLine("Inserisci il tipo di spedizione");
            string tipoconsegna = Console.ReadLine();

            Console.WriteLine("Inserisci il numero di pacchi acquistati");
            int numeroPacchiComprati = int.Parse(Console.ReadLine());

            int costoSpedizioneSingoloPacco = 5;//Dichiarazione + assegnazione
            costoSpedizioneSingoloPacco = 10;//Assegnazione


            int costoTotale = costoSpedizioneSingoloPacco * numeroPacchiComprati;

            //Stampa a video con concatenazione di stringhe e variabili
            //$ è il carattere speciale per l'interpolazione di stringhe
            //Che permette di inserire variabili all'interno di una stringa di messaggio
            Console.WriteLine($"Il tipo di consegna selezionato è: {tipoconsegna}, e il costo totale è: {costoTotale}$");*/


            /*
            Vehicle vehicle = new Vehicle("abc");
            //vehicle.LicensePlate = "abc";
            string license = vehicle.LicensePlate;

            Console.WriteLine(license);

            Vehicle vehicle1 = new Vehicle("xyz", 1, 50,75);
            Console.WriteLine(vehicle1.LicensePlate);
            Console.WriteLine(vehicle1.OdometerKm);
            Console.WriteLine(vehicle1.DailyRate);
            Console.WriteLine(vehicle1.FuellLevelPercentage);
            */
            Enemy enemy = new Enemy();
            enemy.setHealth(1);
            Console.WriteLine($"Enemy Health: {enemy.Health}");
            Console.WriteLine($"Enemy isAlive: {enemy.isAlive()}");
        }
    }
}
