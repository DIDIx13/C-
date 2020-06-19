//
// Je me suis rajouté de la difficulté car je trouve ça plus agréable à corriger j'ai même hésité à faire une class pour loto et des unit tests :p
//
using System;
using System.Collections.Generic;

namespace TP_Darwin_Ameli_OpenClassrooms_Loto
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random(DateTime.Now.Millisecond); // Le DateTime permet à la class Random d'être bien plus aléatoire et imprévisible qu'il ne l'est. (Complètement facultatif)
            List<int> Loto = new List<int>(); // Pourquoi pas utiliser une liste bien plus adapté qu'un tableau dans ce context !

            // La boucle va chercher dans la liste des valeurs possibles et piocher dedans plutôt que de tirer aléatoirement les valeurs et de vérifier que la valeur n'a pas encore été tirée.
            for (int i = 0; i < 7; i++)
            {
                int candidat;

                do
                {
                    candidat = rand.Next(1, 49);
                }
                while (Loto.Exists(x => { return x == candidat; })); // Doc pour Exists: https://msdn.microsoft.com/en-us/library/bfed8bca(v=vs.110).aspx

                Loto.Add(candidat);
            }

            // La boucle permet de chercher tous les éléments et les afficher 
            for (int i = 0; i < Loto.Count; i++)
            {
                Console.WriteLine($"Le numéro {i} est le {Loto[i]}");
            }

            Console.ReadKey(true);
        }
    }
}
