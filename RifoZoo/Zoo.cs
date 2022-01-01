using JetBrains.Annotations;
using RifoZoo.Animals;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RifoZoo
{
    public class Zoo
    {
        private readonly List<Animal> _animals = new();

        public void AdoptAnimal([NotNull] Animal a)
        {
            if (a == null) throw new ArgumentNullException(nameof(a));
            _animals.Add(a);
        }

        //internal void AdoptAnimal(Koala koala)
        //{
        //    throw new NotImplementedException();
        //}

        public int KillAllAnimals()
        {
            var count = _animals.Count;
            foreach (var x in _animals)
            {
                x.Kill();
            }
            return count;
        }
        public IReadOnlyCollection<Animal> GetAllAnimals()
        {
            //var animals = new List<Animal>();
            //animals.Add(new Amphibian());
            return _animals;
        }
        public IEnumerable<Animal> GetAllAliveAnimals()
        {
            return _animals.Where(IsAnimalAlive);
        }

        private bool IsAnimalAlive(Animal a)
        {
            return a.isAlive == true;
        }
        public IEnumerable<Animal> GetAllDeadAnimals()
        {
            return _animals.Where(a => a.isAlive == false);
        }
    }
}

