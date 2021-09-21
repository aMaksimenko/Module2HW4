using HomeWork.Models.Enums;

namespace HomeWork.Models.WarmBlooded.Bird
{
    public class Eagle : Bird
    {
        public override Size Size { get; init; } = Size.Medium;
        public override bool IsPredator { get; init; } = true;
        public override bool IsInTribe { get; init; } = false;
    }
}