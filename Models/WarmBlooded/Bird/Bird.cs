using HomeWork.Models.Enums;

namespace HomeWork.Models.WarmBlooded.Bird
{
    public abstract class Bird : WarmBlooded
    {
        public override WarmBloodedType Type { get; init; } = WarmBloodedType.Bird;
    }
}