using HomeWork.Models;
using HomeWork.Models.Enums;

namespace HomeWork.Services.Abstractions
{
    public interface ICounterService
    {
        public Counter[] Count(Animal[] animals);
    }
}