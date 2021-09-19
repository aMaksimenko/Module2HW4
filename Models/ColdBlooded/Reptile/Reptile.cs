using HomeWork.Models.Enums;

namespace HomeWork.Models.ColdBlooded.Reptile
{
    public abstract class Reptile : ColdBlooded
    {
        public override ColdBloodedType Type { get; init; } = ColdBloodedType.Reptile;
    }
}