using HomeWork.Models.Enums;

namespace HomeWork.Models.WarmBlooded.Mammal
{
    public class Lion : Mammal
    {
        public override Size Size { get; init; } = Size.Medium;
        public override bool IsPredator { get; init; } = true;
        public override bool IsInTribe { get; init; } = true;
    }
}