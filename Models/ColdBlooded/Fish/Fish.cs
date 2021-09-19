using HomeWork.Models.Enums;

namespace HomeWork.Models.ColdBlooded.Fish
{
    public abstract class Fish : ColdBlooded
    {
        public override ColdBloodedType Type { get; init; } = ColdBloodedType.Fish;
    }
}