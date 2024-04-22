using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_AdHanz
{
    public class fifo
    {
        private int[] prvky;
        private int[] cervena;
        private int[] modra;
        private int pocet = 0;

        public fifo()
        {
            cervena = new int[1];
            modra = new int[2];
            prvky = new int[10]; 
        }

        public int Count()
        {
            return pocet;

        }
        public int[] GetCervena() 
        {
            return cervena;
            pocet += 1;
        }

        
        public int[] GetModra() 
        {  
            return modra;
            pocet -= 1;
        }

        public int Pop()
        {
            pocet -= 1;
            GetModra();
            return pocet;
        }

        public void Push (int prvky)
        {

            if (pocet == prvky.Length)
            {
                int[] novePole = new int[2 * prvky.Length];

                for (int i = 0; i < prvky.Length; i++)
                    novePole[i] = prvky[i];

                prvky = novePole;
            }

            prvky[pocet] = prvky;
            pocet += 1;
        }

    }
}
