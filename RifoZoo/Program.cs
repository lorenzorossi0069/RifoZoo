using RifoZoo.Animals;
using RifoZoo.Animals.Amphibians.Crocodiles;
using System;
using System.Globalization;

namespace RifoZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to (Rifo) Zoo");
            var zoo = new Zoo();

            Console.WriteLine("Adotto animali");
            zoo.AdoptAnimal(new Koala
            {
                Description = "Animale carino adottato il " + DateTime.Now.ToString(new CultureInfo("it-IT")),
                Name = "Gino"
            });
            var crocco1 = new Crocodile();
            crocco1.Name = "Pino";
            crocco1.Description = "Animale cattivissimo adottato il " + DateTime.Now;
            zoo.AdoptAnimal(crocco1);
            zoo.AdoptAnimal(new NileCrocodile()
            {
                Name = "Camillino",
            });
            zoo.AdoptAnimal(new SaltwaterCrocodile()
            {
                Name = "Salino",
            });

            Console.WriteLine("\nChe animali ho?");
            foreach(var a in zoo.GetAllAnimals())
            {
                Console.WriteLine("- {0}", a.FriendlyName);
            }
            Console.WriteLine("\nuccido croco1");
            crocco1.Kill();
            Console.WriteLine("\nChe animali ho? (vers {0} con GetType())");
            foreach (var a in zoo.GetAllAnimals())
            {
                Console.WriteLine("- {0} | {1}",a.GetType(), a.FriendlyName);
            }
            Console.WriteLine("\nChe animali ho? (rifo con {0} ToSting()");
            foreach (var a in zoo.GetAllAnimals())
            {
                Console.WriteLine("- {0} | {1}", a.ToString(), a.FriendlyName);
            }
            Console.WriteLine("\nChe animali ho? (rifo con {0} senza nulla=invoke overriden ToString!!!");
            foreach (var a in zoo.GetAllAnimals())
            {
                Console.WriteLine("- {0} | {1}", a, a.FriendlyName);
            }
            Console.WriteLine("\nChe animali VIVI ho?");
            foreach (var a in zoo.GetAllAliveAnimals())
            {
                Console.WriteLine("- {0} | {1}",a.ToString(), a.FriendlyName);
            }


        }
    }
}

