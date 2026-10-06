using System;
using System.Collections.Generic;
using System.Text;

namespace BlaisePascal.Esempio.Domain
{
    public class Enemy
    {
        //attribto
        private int _health;

        //proprietà 
        //public int Health { get; set; } // proprietà con accesso pubblico in lettura e scrittura
        public int Health { get;  private set; }
        
        
        //public int Health
        //{
        //    get
        //    {
        //        return _health;
        //    }  
        //    set
        //    {
        //        if(value < 0)//caso limite 1
        //        {
        //            _health = 0;
        //        }else if ( value > 100)//caso limite 2
        //        {
        //            _health = 100;
        //        }
        //        else // caso normale
        //        {
        //            _health = value;
        //        }
        //    }
        //}
       
     

        //costruttore
        public Enemy() { }


        public void  setHealth(int newHealth)
        {
            if (newHealth < 0)
                Health = 0; // se il corpo del costrutto è solo di una riga, allora posso emettere le parentesi graffe
            else if (newHealth > 100)
                Health = 100;
            else
                Health = newHealth;
        }
        public bool isAlive() 
        {
            return _health > 0;
        }
         public void TakeDamage(int damage)
        {
            if( damage <0)
                damage = 0;
            setHealth(Health - damage);
        }
    }
}
