using HomeWork.Models.Enums;

namespace HomeWork.Models.WarmBlooded.Bird
{
    public class Hummingbird : Bird
    {
        public override Size Size { get; init; } = Size.Small;
        public override bool IsPredator { get; init; } = false;
        public override bool IsInTribe { get; init; } = false;
    }
}