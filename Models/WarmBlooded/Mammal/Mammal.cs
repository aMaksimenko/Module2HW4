using HomeWork.Models.Enums;

namespace HomeWork.Models.WarmBlooded.Mammal
{
    public abstract class Mammal : WarmBlooded
    {
        public override WarmBloodedType Type { get; init; } = WarmBloodedType.Mammal;
    }
}