namespace BlaisePascal.Esempio.Domain
{
    /// <summary>
    ///
    /// </summary>
    public class Enemy
    {
        //private: modificatore di accesso che indica che la variabile è accessibile solo all'interno della classe Enemy
        //int: tipo di dato intero
        // _health: nome dell'attributo che rappresenta la salute del nemico
        private int health; //mutabile

        //attributo costante
        private const int MaxHealth = 100; // costante che rappresenta la salute massima del nemico

        //Costrutture pubblico per instaziare un oggetto Eneny con salute iniziale
        public Enemy() { }
    }
}
