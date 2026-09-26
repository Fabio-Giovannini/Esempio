public class Program // Questa è una classe
{
    //Metodo di entrata per esecuzione del codice
    public static void Main()
    {
    
        Console.WriteLine("Benvenuto nella libreria Easy Library");

        int costoSpedizioneSingoloPacco = 5;//Dichiarazione + assegnazione
        costoSpedizioneSingoloPacco = 10;//Assegnazione

        int numeroPacchiComprati = 2;

        string tipoConsegna = "Standard";//Dichiarazione

        int costoTotale = costoSpedizioneSingoloPacco * numeroPacchiComprati;

        //Stampa a video con concatenazione di stringhe e variabili
        //$ è il carattere speciale per l'interpolazione di stringhe
        //Che permette di inserire variabili all'interno di una stringa di messaggio
        Console.WriteLine($"Il tipo di consegna selezionato è: {tipoConsegna}, e il costo totale è: {costoTotale}$");
        

    }
}
