using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignmentno2;
using NUnit.Framework;

namespace TestAnalyse
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Check_Scalene_Triangle_10_20_15()
        {
            String output = TriangleSolver.Analyze(10, 20, 15);
            Console.Write(output);
        }
        [Test]
        public void Check_Scalene_Triangle_183_195_220()
        {
            String output = TriangleSolver.Analyze(183, 195, 220);
            Console.Write(output);
        }
        [Test]
        public void Check_Not_Formed_Triangle_Sides_37_5_83()
        {
            String output = TriangleSolver.Analyze(37, 5, 83);
            Console.Write(output);
        }
        [Test]
        public void Check_Not_Formed_Triangle_Sides_0_0_0()
        {
            String output = TriangleSolver.Analyze(0, 0, 0);
            Console.Write(output);
        }
        [Test]
        public void Check_Equilateral_Triangle_54_54_54()
        {
            String output = TriangleSolver.Analyze(54, 54, 54);
            Console.Write(output);
        }
        [Test]
        public void Check_Equilateral_Triangle_300_300_300()
        {
            String output = TriangleSolver.Analyze(300, 300, 300);
            Console.Write(output);
        }
        [Test]
        public void Check_Isosceles_Triangle_65_65_55()
        {
            String output = TriangleSolver.Analyze(65, 65, 55);
            Console.Write(output);
        }
        [Test]
        public void Check_Isosceles_Triangle_400_500_400()
        {
            String output = TriangleSolver.Analyze(400, 500, 400);
            Console.Write(output);
        }
    }
}
