using HomeWork.Models.Enums;

namespace HomeWork.Models.ColdBlooded
{
    public abstract class ColdBlooded : Animal
    {
        public override BloodType BloodType { get; init; } = BloodType.Cold;

        public abstract ColdBloodedType Type { get; init; }
    }
}