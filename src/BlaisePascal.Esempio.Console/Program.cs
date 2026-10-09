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
            MAIN -> Esempio
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
            Console.WriteLine($"Il tipo di consegna selezionato è: {tipoconsegna}, e il costo totale è: {costoTotale}$");
            */


            /*
            //MAIN per la classe Vehicle
            Vehicle vehicle = new Vehicle("abc");
            //vehicle.LicensePlate = "abc";
            string license = vehicle.LicensePlate;

            Console.WriteLine(license);

            try
            {
                Vehicle vehicle1 = new Vehicle("xyz", -1, 50, 75);
                Console.WriteLine(vehicle1.LicensePlate);
                Console.WriteLine(vehicle1.OdometerKm);
                Console.WriteLine(vehicle1.DailyRate);
                Console.WriteLine(vehicle1.FuelLevelPercentage);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            */


            /*
            MAIN -> MAin per la classe Enemy
            Enemy enemy = new Enemy();
            enemy.setHealth(1);
            Console.WriteLine($"Enemy Health: {enemy.Health}");
            Console.WriteLine($"Enemy isAlive: {enemy.isAlive()}");
            */

            //MAIN -> Main per la classe Player
            try
            {
                Player player1 = new Player("Fabio");
                player1.AddExperience(120);
                player1.TakeDamage(250);
                player1.Heal(50);
                player1.AddGOld(157);


                Console.WriteLine($"Player Name: {player1.Name}");
                Console.WriteLine($"Player Level: {player1.Level}");
                Console.WriteLine($"Player Experience: {player1.Experience}");
                Console.WriteLine($"Player Health: {player1.Health}");
                Console.WriteLine($"Player Max Health: {player1.MaxHealth}");
                Console.WriteLine($"Player Gold: {player1.Gold}");
                Console.WriteLine($"Player Is Alive: {player1.IsAlive}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error message: {ex.Message}");
            }
        }
    }
}
