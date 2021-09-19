using HomeWork.Models.Enums;

namespace HomeWork.Models
{
    public abstract class Animal
    {
        public abstract Size Size { get; init; }
        public abstract bool IsPredator { get; init; }
        public abstract bool IsInTribe { get; init; }
        public abstract BloodType BloodType { get; init; }
    }
}