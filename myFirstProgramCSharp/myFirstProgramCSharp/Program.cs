using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirstProgramCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Yellow;

            // Jouer avec des For

            for (int x = 0; x <= 10; x++)
            {
                Console.WriteLine("La valeur de x : " + x.ToString());

                if (x == 7)
                {
                    Console.WriteLine("Trouvé la valeur 7");
                    break;
                }
            }

            // Jouer avec des If/Else

            Console.WriteLine("Saisissez le type d'opération Multiplier (m) ou Diviser (d) : ");
            String decision = Console.ReadLine();
            Console.WriteLine("Saisisez un chiffre");
            String chaineChiffre = Console.ReadLine();
            int chiffre = Convert.ToInt32(chaineChiffre);

            if (decision == "m")
            {
                chiffre *= chiffre;
                Console.WriteLine(" Résultat de la multilication = " + chiffre.ToString());
            }
            else if (decision == "d")
            {
                chiffre /= chiffre;
                Console.WriteLine(" Résultat  de la division = " + chiffre.ToString());
            }
            else
            {
                Console.WriteLine("Vous n'avez pas saissi une information correcte.");
            }
            Console.Read(); 
        }
    }
}
