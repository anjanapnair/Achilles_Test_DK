using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeOfTriangle
{
    /// <summary>
    /// To determine the type of a triangle, given the length of three sides
    /// </summary>
    public class Triangle
    {        

        public enum TriangleType
        {
            Scalene,
            Isosceles,
            Equilateral
        }

        //DetermineTypeOfTriangle checks whether the triangle is Scalene, Isosceles, or Equilateral
        public static TriangleType DetermineTypeOfTriangle(double sideA, double sideB, double sideC)
        {
            TriangleType type;
            if ((sideA == sideB) && (sideA == sideC))
            {
                type = TriangleType.Equilateral;
            }
            else if ((sideA == sideB) || (sideA == sideC) || (sideB == sideC))
            {
                type = TriangleType.Isosceles;               
            }
            else
            {
                type = TriangleType.Scalene;

            }

            return type;
        }

        //CheckInvalidLengths checks for Invalid lengths such as zero and negative values.
        public static bool CheckInvalidLengths(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                return false;
            else
                return true;
        }

        

        public static void Main(string[] args)
        {

            double sideA, sideB, sideC;
            Console.Write("------Determine the type of Triangle--------\n");            

            do
            {
                while (true)
                {
                    try
                    {

                        Console.Write("\nLength of Side 1: ");
                        sideA = Convert.ToDouble(Console.ReadLine());
                        Console.Write("\nLength of Side 2: ");
                        sideB = Convert.ToDouble(Console.ReadLine());
                        Console.Write("\nLength of Side 3: ");
                        sideC = Convert.ToDouble(Console.ReadLine());

                        Console.Write("\nThree sides are:- \n");
                        Console.Write(sideA + " " + sideB + " " + sideC + "\n");
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("\nWaiting..!");
                        continue;
                    }

                }

                if (CheckInvalidLengths(sideA, sideB, sideC))
                {
                    TriangleType type = DetermineTypeOfTriangle(sideA, sideB, sideC);
                    Console.WriteLine("\nThis triangle is " + type);
                }

                else
                {
                    Console.WriteLine("\nInvalid length!");
                }

                Console.WriteLine("\n---Press any key to continue | X to return---\n");
            } while (Console.ReadKey().Key != ConsoleKey.X);
        }
    }
}


