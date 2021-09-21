using System;
using System.Linq;
using HomeWork.Models;
using HomeWork.Models.Enums;
using HomeWork.Services.Abstractions;

namespace HomeWork.Services
{
    public class CounterService : ICounterService
    {
        private uint _nextCounterIndex;

        public Counter[] Count(Animal[] animals)
        {
            var result = new Counter[animals.Length];

            foreach (var animal in animals)
            {
                Counter itemToUpdate = null;

                foreach (var itemResult in result)
                {
                    if (itemResult != null && itemResult.Title == animal.GetType().Name)
                    {
                        itemToUpdate = itemResult;
                        break;
                    }
                }

                if (itemToUpdate != null)
                {
                    itemToUpdate.Value++;
                }
                else
                {
                    result[_nextCounterIndex] = new Counter()
                    {
                        Title = animal.GetType().Name,
                        Value = 1,
                    };
                    _nextCounterIndex++;
                }
            }

            return result.Where(item => item != null).ToArray();
        }
    }
}