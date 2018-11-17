using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
   abstract class Pojazd
    {
        private float fCenaZakupu;
        private float fMarza;
        private int iRokProdukcji;

         float Marza
        {
            get
            {
                return fMarza;
            }
        
        }
         float CenaZakupu
        {
            get
            {
                return fCenaZakupu;
            }
            
        }
         int RokProdukcji
        {
            get
            {
                return iRokProdukcji;
            }
            
        }

        void wyswietlRok()
        {

        }
        
        float podajCeneKoncowa()
        {
            float cenakoncowa;
            cenakoncowa = CenaZakupu + Marza;

            return cenakoncowa;
        }

        public abstract string wyswietlMarke();
        
        public abstract string wyswietlModel();

        public abstract string wyswietlTypPojazdu();    
        

    }
}
