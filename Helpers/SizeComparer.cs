using System.Collections;
using HomeWork.Models;

namespace HomeWork.Helpers
{
    public class SizeComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x == null || y == null)
            {
                return 0;
            }

            var xAnimal = x as Animal;
            var yAnimal = y as Animal;

            switch (xAnimal?.Size - yAnimal?.Size)
            {
                case >0:
                    return 1;
                case <0:
                    return -1;
            }

            return 0;
        }
    }
}