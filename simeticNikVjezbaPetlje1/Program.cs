using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simeticNikVjezbaPetlje1
{
    class Program
    {
        static void Main(string[] args)
        {
            int ocjena;
            float prosjek;
            float brojOcjena = 0;
            int zbrojOcjena = 0;

            do
            {



                Console.WriteLine("Upisite ocjenu:");
                ocjena = Convert.ToInt32(Console.ReadLine());
                
                
                if (ocjena == 1)
                {
                    prosjek = 1;
                    break;
                }

                else if(ocjena > 5 || ocjena < 0)
                    {
                        Console.WriteLine("Kriva ocjena. Unesi ponovno");

                    }
                else if(ocjena != 0)
                    {
                        brojOcjena++;
                        zbrojOcjena += ocjena;
                    

                }
                prosjek = zbrojOcjena / brojOcjena;
            }
             while (ocjena != 0);
            Console.WriteLine("Prosjek ocjena je: " + prosjek);
            Console.ReadKey();
            }
    }
}
