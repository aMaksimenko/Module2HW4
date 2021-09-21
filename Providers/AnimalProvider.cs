using HomeWork.Models;
using HomeWork.Models.ColdBlooded.Fish;
using HomeWork.Models.ColdBlooded.Reptile;
using HomeWork.Models.WarmBlooded.Bird;
using HomeWork.Models.WarmBlooded.Mammal;
using HomeWork.Providers.Abstractions;

namespace HomeWork.Providers
{
    public class AnimalProvider : IAnimalProvider
    {
        public Animal[] GetAnimals()
        {
            return new Animal[]
            {
                new Piranha(),
                new Piranha(),
                new Piranha(),
                new Piranha(),
                new Shark(),
                new Snake(),
                new Turtle(),
                new Eagle(),
                new Eagle(),
                new Eagle(),
                new Hummingbird(),
                new Hummingbird(),
                new Hummingbird(),
                new Hummingbird(),
                new Hummingbird(),
                new Hummingbird(),
                new Hummingbird(),
                new Hummingbird(),
                new Bear(),
                new Bear(),
                new Bear(),
                new Lion(),
                new Lion(),
            };
        }
    }
}