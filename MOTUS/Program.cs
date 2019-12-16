using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOTUS
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int TMot= VerifierMot();
            Console.WriteLine("la taille du mot à deviner est de " + TMot+" caractères");
            char[] BonMot= RechercherDico(TMot);

            Console.WriteLine("Réponse?");
            string Reponse = Console.ReadLine();
            char[] MotJoueur = ConvertirMotJoueur(Reponse);

            //on verifie si les deux mots sony de la meme taille

            Console.ReadKey();
        }
        static int VerifierMot()
        {
            int TMot;
            do
            {
                Console.WriteLine("Quelle est la taille du mot? ");
                TMot = int.Parse(Console.ReadLine());
            }
            while (TMot < 6 || TMot > 10);

            return TMot;
        }
        static char[]  RechercherDico(int TMot)
        {
            char[] BonMot = new char[TMot];
            //chercher dans la liste de dictionnaire où le nombre de caractère=TMot
            return BonMot;

        }
        static char[] ConvertirMotJoueur (string MotJoueur)
        {
            int n = MotJoueur.Length;
            char[] TabMotJoueur = new char[n];
            for (int k =0; k<n; k++ )
            {
                TabMotJoueur[k] = MotJoueur[k];
            }
            return TabMotJoueur;
        }
    }
}
