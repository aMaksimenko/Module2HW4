using System;
using HomeWork.Helpers;
using HomeWork.Models;
using HomeWork.Models.Enums;
using HomeWork.Services.Abstractions;

namespace HomeWork
{
    public class App
    {
        private readonly ISafariService _safariService;

        public App(ISafariService safariService)
        {
            _safariService = safariService;
        }

        public void Run()
        {
            _safariService.Fill();

            var animalCountersByType = _safariService.GetCountersByType();

            foreach (var animalCounter in animalCountersByType)
            {
                Console.WriteLine($"{animalCounter.Title} => {animalCounter.Value}");
            }

            Console.WriteLine("=======================");

            foreach (var animal in _safariService.GetAnimals())
            {
                Console.WriteLine($"{animal.GetType().Name} size => {animal.Size}");
            }

            Console.WriteLine("=======================");

            _safariService.SortBySize();
            foreach (var animal in _safariService.GetAnimals())
            {
                Console.WriteLine($"{animal.GetType().Name} size => {animal.Size}");
            }

            Console.WriteLine("=======================");

            Console.WriteLine(_safariService.GetAnimals().FindPredatorBySize(Size.Medium, true));
        }
    }
}