using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalieriKontrolaPlnoletosti
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej rok narození: ");
            int zadanyVek = -1;
            bool jeZadanVek = int.TryParse(Console.ReadLine(), out zadanyVek);
            
            if(jeZadanVek)
            {
                int vypocitanyVek = DateTime.Now.Year - zadanyVek;
                if (zadanyVek != -1 && vypocitanyVek >= 18)
                {
                    Console.WriteLine("Můžeš vstoupit do Salieriho baru...");
                }
                else
                {
                    Console.WriteLine("Vypadni odsud, než zavolám tvojí mámě, ty spratku!");
                }
            }

            Console.ReadLine();
        }
    }
}
