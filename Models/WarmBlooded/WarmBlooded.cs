using HomeWork.Models.Enums;

namespace HomeWork.Models.WarmBlooded
{
    public abstract class WarmBlooded : Animal
    {
        public override BloodType BloodType { get; init; } = BloodType.Warm;
        public abstract WarmBloodedType Type { get; init; }
    }
}