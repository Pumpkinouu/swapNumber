//ETML
//Auteur      : Danilo Zivanovic
//Date        : 16.11.2023
//Descritpion : Ce programme fera un swap de deux variables, après exécution, la variable 1 contient la valeur de la variable 2 et vice-versa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapDaniloZivanovic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /////////////// Déclaration de variables //////////

            byte bytVariable1;   //Variable qui va contenir la valeur saisie
            byte bytVariable2;   //Variable qui va contenir la valeur saisie
            byte bytTempo = 0;   //Valeur avec une valeur de base 

            /////////////// Programme principal //////////////

            /// Affichage du titre
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("         Inversion du contenue de 2 variables          ");
            Console.WriteLine("-------------------------------------------------------");

            /// Affichage de la première saisie de l'utilisateur
            Console.Write("\nEntrer la valeur de la variables 1: ");
            bytVariable1 = Convert.ToByte(Console.ReadLine());

            /// Affichage de la deuxième saisie de l'utilisateur
            Console.Write("\nEntrer la valeur de la variables 2: ");      
            bytVariable2 = Convert.ToByte(Console.ReadLine());

            /// Affichage du titre du tableau 
            Console.WriteLine("\n\nEvolution des valeurs:            Variables 1      Variable 2      Tempo");
            Console.WriteLine("------------------------------------------------------------------------------");

            /// Affichage du tableau avec les valeurs et les inversions
            Console.WriteLine("\nValeur de départs: = {0,19} {1,16} {2,12}", bytVariable1, bytVariable2, bytTempo);
            Console.WriteLine("\nEtape 1          : = {0,19} {1,16} {2,12}", bytVariable1, bytVariable2, bytVariable1);
            Console.WriteLine("Etape 2          : = {0,19} {1,16} {2,12}", bytVariable2, bytVariable2, bytVariable1);
            Console.WriteLine("Etape 3          : = {0,19} {1,16} {2,12}", bytVariable2, bytVariable1, bytVariable1);

            /// Affichage du contenue des variables
            Console.WriteLine("\nLa variable 1 contient: {0}", bytVariable2);
            Console.WriteLine("\nLa variable 2 contient: {0}", bytVariable1);

            /// Affichage de la dernière phrase
            Console.Write("\nAppuyez sur une touche pour continuer...");
            Console.ReadLine();
        }
    }
}
