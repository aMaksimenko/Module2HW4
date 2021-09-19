using HomeWork.Models.Enums;

namespace HomeWork.Models.ColdBlooded.Fish
{
    public class Piranha : Fish
    {
        public override Size Size { get; init; } = Size.Small;
        public override bool IsPredator { get; init; } = true;
        public override bool IsInTribe { get; init; } = true;
    }
}