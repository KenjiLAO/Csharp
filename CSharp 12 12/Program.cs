using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_12_12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("--------------Short en byte--------------");

            short s = 300;
            byte q = (byte)s;
            Console.WriteLine(q);

            //La valeur du byte va de 0 à 255 donc on repart de 0 lorsque l'on compte : 300 - 255 = 45 - 1 (car on repart de 0) = 44

            Console.WriteLine("--------------Enum--------------");


            LesJoursDeLaSemaine weekEnd = LesJoursDeLaSemaine.Samedi | LesJoursDeLaSemaine.Dimanche;
            Console.WriteLine("Jours : " + weekEnd);

            // Enum permet d'appeler des variables fixes sans possibilité de les changer

            //int[,] Tableau = new int[1, 2];
            //int[,,] Tableau = new int[5, 2, 3];

            int[][] Tableau = new int[3][];
            Tableau[0] = new int[] { 42, 2 , 56};
            Tableau[1] = new int[] { 54, 25 , 1 , 35 , 56};

            Console.WriteLine("--------------Tableaux--------------");

            // Expliquer la différence entre ces systèmes
            // L'instanciation des tableaux est différente, le deuxième système est plus simple d'appréhension

            //Tentez de parcourir des tableaux multidimensionnels avec des boucles for
            for (int index = 0; index < Tableau.Length-1; index++) {
                for (int index1 = 0; index1 < Tableau[index].Length; index1++)
                {
                    Console.WriteLine("Parcours du tableau multidimensionnel" + " : " + Tableau[index][index1]);//Affiche tous les éléments de Tableau
                }
            }
            Console.ReadLine();
            Console.ReadKey();
        }

        enum LesJoursDeLaSemaine
        {
            Lundi,
            Mardi,
            Mercredi,
            Jeudi,
            Vendredi,
            Samedi,
            Dimanche
        }

    }
}