using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chatboticek___
{
    class Certik
    {
        enum Zdvorilost { tykani, vykani }
        enum Pozdrav { ahoj, [Description("dobrý den")] bryden, čau}
        enum pocasi { počasí, pocasi }
        enum doprava { doprava, dopravu, dopravy, dopravo, dopravě, dopravou}
        enum Hra { hru , hra, her , hry, hrách, hro, hře, hrou, hrám, hrama}


        Zdvorilost Zdar;

        private void Rozcestnik()
        {

        }

        private string pozdrav()
        {
            string pozdrav = Console.ReadLine();

            if((string.Equals(pozdrav, "Ahoj", StringComparison.CurrentCultureIgnoreCase)))
            {
                Zdar = Zdvorilost.tykani;
            }
            if ((string.Equals(pozdrav, "Čau", StringComparison.CurrentCultureIgnoreCase)))
            {

                Zdar = Zdvorilost.tykani;
            }
            if ((string.Equals(pozdrav, "Dobrý den", StringComparison.CurrentCultureIgnoreCase)))
            {      
                Zdar = Zdvorilost.vykani;
            }

            return pozdrav;
        }
    
        

        private void Pocasi()
        {

        }
    }
    class Hra
    {
        int odhad = 50;
        int h_hranice = 100;
        int d_hranice = 0;
        bool viertich = false;

        public void Start()
        {
            Console.WriteLine(odhad);


            while (viertich == false)
            {
                string odpoved = Console.ReadLine();

                Console.WriteLine(Tah(odpoved));
            }
        }
        
        public int Tah(string vetsimensi)
        {


            if (vetsimensi == "větší")
            {
                d_hranice = odhad;
            }
            if (vetsimensi == "menší")
            {
                h_hranice = odhad;
                
            }
            if (vetsimensi == "správně")
            {
                //slay
                viertich = true;
            }
            if(d_hranice == h_hranice)
            {
                Console.WriteLine("kecas :(");
            }

            odhad = d_hranice + (h_hranice - d_hranice) / 2;

            return odhad;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Hra hra = new Hra();
            hra.Start();
        }
    }
}
