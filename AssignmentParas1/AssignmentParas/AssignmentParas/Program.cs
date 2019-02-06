using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmentno2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFromMenu = string.Empty;
            int intInputFromMenu = 0;
            bool isExit = false;
            string analyzeOutput = string.Empty;
            do
            {
                isExit = false;
                Console.WriteLine("1. Enter triangle dimensions");
                Console.WriteLine("2. Exit");
                inputFromMenu = Console.ReadLine();
                try
                {
                    intInputFromMenu = int.Parse(inputFromMenu);

                    switch (intInputFromMenu)
                    {
                        case 1:
                            int firstSide = 0;
                            int secondSide = 0;
                            int thirdSide = 0;
                            do
                            {
                                Console.WriteLine("Enter the First side: ");
                                firstSide = checkTriangleSide(Console.ReadLine());
                            } while (firstSide == 0);
                            do
                            {
                                Console.WriteLine("Enter the Second side: ");
                                secondSide = checkTriangleSide(Console.ReadLine());
                            } while (secondSide == 0);
                            do
                            {
                                Console.WriteLine("Enter the Third side: ");
                                thirdSide = checkTriangleSide(Console.ReadLine());
                            } while (thirdSide == 0);

                            analyzeOutput = TriangleSolver.Analyze(firstSide, secondSide, thirdSide);
                            Console.WriteLine(analyzeOutput);
                            break;
                        case 2:
                            isExit = true;
                            break;
                        default:
                            Console.WriteLine("Sorry, please select valid option");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Sorry, please select valid option");
                }
            } while (!isExit);
        }
        public static int checkTriangleSide(String side)
        {
            int triangleSide = 0;
            if (!int.TryParse(side, out triangleSide) || triangleSide <= 0)
            {
                Console.Write("Please enter vaid length of triangle\n");
            }
            return triangleSide;
        }
    }
}
