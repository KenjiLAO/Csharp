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
            Console.WriteLine("Hello world");

            short s = 300;
            byte q = (byte)s;
            Console.WriteLine(q);


            LesJoursDeLaSemaine weekEnd = LesJoursDeLaSemaine.Samedi | LesJoursDeLaSemaine.Dimanche;
            Console.WriteLine("Jours : " + weekEnd);

            int[][] Tableau = new int[3][];
            Tableau[0] = new int[] { 42, 2 , 56};
            Tableau[1] = new int[] { 54, 25 , 1 , 35 , 56};



            //Tentez de parcourir des tableaux multidimensionnels avec des boucles for
            for (int index = 0; index < Tableau.Length-1; index++) {
                for (int index1 = 0; index1 < Tableau[index].Length; index1++)
                {
                    Console.WriteLine("Parcours du tableau multidimensionnel" + " : " + Tableau[index][index1]);//Afficher tous les éléments de Tableau
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