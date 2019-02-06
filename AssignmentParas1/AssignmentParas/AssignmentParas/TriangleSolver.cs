using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmentno2
{
    public static class TriangleSolver
    {
        public static string Analyze(int firstSide, int secondSide, int thirdSide)
        {
            String triangleCategory = string.Empty;
            if ((secondSide + thirdSide <= firstSide || firstSide + secondSide <= thirdSide || firstSide + thirdSide <= secondSide))
                triangleCategory = "Unable to create a triangle";
            else if (firstSide == secondSide && secondSide == thirdSide)
                triangleCategory = "Equilateral Triangle";
            else if (firstSide != secondSide && secondSide != thirdSide && thirdSide != firstSide)
                triangleCategory = "Scalene Triangle";
            else if ((firstSide == secondSide && secondSide != thirdSide) || (firstSide != secondSide && thirdSide == firstSide) || (thirdSide == secondSide && thirdSide != firstSide))
                triangleCategory = "Isosceles Triangle";
            return triangleCategory;
        }
    }
}
