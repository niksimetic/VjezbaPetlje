using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nikŠimetićPetljeDz
{
    class Program
    {
        static void Main(string[] args)
        {
            int ocjena, brOc = 0, prosjek = 0;
            Console.WriteLine("Upisite ocjene: ");
       
        nazad:

            ocjena = Convert.ToInt32(Console.ReadLine());

            do
            {

                if (ocjena == 1)
                {
                    Console.WriteLine("Prosjek je 1 ");
                    goto dalje;
                }
                
                if (ocjena < 1 || ocjena > 5)
                {
                    Console.WriteLine("Nije ocjena. Probajte ponovno");
                    
                    goto nazad;

                }
                prosjek = prosjek + ocjena;
                brOc++;
             

            prosjek = prosjek / brOca;
            Console.WriteLine("Prosjek je: " + prosjek);

        dalje:

            Console.ReadKey();
        }
    }
}
