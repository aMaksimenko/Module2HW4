using HomeWork.Models.Enums;

namespace HomeWork.Models.ColdBlooded.Reptile
{
    public class Turtle : Reptile
    {
        public override Size Size { get; init; } = Size.Small;
        public override bool IsPredator { get; init; } = false;
        public override bool IsInTribe { get; init; } = false;
    }
}