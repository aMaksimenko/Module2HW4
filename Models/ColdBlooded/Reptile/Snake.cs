using HomeWork.Models.Enums;

namespace HomeWork.Models.ColdBlooded.Reptile
{
    public class Snake : Reptile
    {
        public override Size Size { get; init; } = Size.Small;
        public override bool IsPredator { get; init; } = true;
        public override bool IsInTribe { get; init; } = false;
    }
}