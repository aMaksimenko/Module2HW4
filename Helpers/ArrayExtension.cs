using HomeWork.Models;
using HomeWork.Models.Enums;

namespace HomeWork.Helpers
{
    public static class ArrayExtension
    {
        public static object FindPredatorBySize(this Animal[] animals, Size size, bool isPredator)
        {
            Animal result = null;
            foreach (var animal in animals)
            {
                if (animal != null && animal.Size == size && animal.IsPredator == isPredator)
                {
                    result = animal;
                    break;
                }
            }

            return result;
        }
    }
}