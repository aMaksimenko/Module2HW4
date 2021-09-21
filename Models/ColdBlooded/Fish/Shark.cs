using HomeWork.Models.Enums;

namespace HomeWork.Models.ColdBlooded.Fish
{
    public class Shark : Fish
    {
        public override Size Size { get; init; } = Size.Large;
        public override bool IsPredator { get; init; } = true;
        public override bool IsInTribe { get; init; } = false;
    }
}