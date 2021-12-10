using System;

namespace record
{
    public record Voiture(string Marque, string Modele);
    // records = structure de données comme une classe, très simple à mettre en place avec des méthodes ajoutées automatiquement.
    // très pratiques pour enregistrer des données reçues ou à envoyer
    // immutables
    // implémente automatiquement l'égalité basée sur les valeurs (pas les références)
    // renvoie un hashcode 
    // facile à copier et cloner
    // possibilité d'imprimer les attributs et réécrit le tostring
    // permet de déconstruire facilement
    // peut être hérité
    public record Decapotable : Voiture
    {
        public bool Toit { get;}
        public Decapotable(string Marque, string Modele, bool Toit):base(Marque, Modele)
        {
            Toit = Toit;
        }

    }

    public class Moto
    {
        public string Marque;

        public Moto(string marque)
        {
            Marque = marque;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Voiture voiture = new Voiture("Tesla", "S");
            Voiture v2 = new Voiture("Tesla", "S");
            //Moto m1 = new Moto("yamaha");

            Console.WriteLine(voiture.ToString());
            voiture.Deconstruct(out string marque, out string modele);
            Console.WriteLine(marque + " " + modele);

            //Console.WriteLine(m1);
            //Console.WriteLine(v2);

            //// créer un record depuis un autre avec une valeur légèrement différente
            //Voiture v3 = v2 with { Marque = "Lada" };
            //Console.WriteLine(v3);

            //// cloner facilement
            //Voiture v4 = v3;
            //Console.WriteLine(v4);
        }
    }
}
