using HomeWork.Models;
using HomeWork.Models.Enums;

namespace HomeWork.Services.Abstractions
{
    public interface ISafariService
    {
        public void Fill();
        public void Clear();
        public Animal[] GetAnimals();
        public Counter[] GetCountersByType();
        public void SortBySize();
    }
}