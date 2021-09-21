using System;
using HomeWork.Helpers;
using HomeWork.Models;
using HomeWork.Models.Enums;
using HomeWork.Providers.Abstractions;
using HomeWork.Services.Abstractions;

namespace HomeWork.Services
{
    public class SafariService : ISafariService
    {
        private readonly IAnimalProvider _animalProvider;
        private readonly ICounterService _counterService;

        public SafariService(IAnimalProvider animalProvider, ICounterService counterService)
        {
            _animalProvider = animalProvider;
            _counterService = counterService;
        }

        private Animal[] Animals { get; set; }

        public void Fill()
        {
            Animals = _animalProvider.GetAnimals();
        }

        public void Clear()
        {
            Animals = null;
        }

        public Animal[] GetAnimals()
        {
            return Animals;
        }

        public Counter[] GetCountersByType()
        {
            return _counterService.Count(Animals);
        }

        public void SortBySize()
        {
            Array.Sort(Animals, new SizeComparer());
        }
    }
}