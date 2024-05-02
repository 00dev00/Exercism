using System;
using System.Collections.Generic;
using System.Linq;

public static class Triangle
{
    public static bool IsScalene(double side1, double side2, double side3) => 
        isTriangle(side1, side2, side3) &&
        new List<double> { side1, side2, side3 }.Distinct().Count() == 3;

    public static bool IsIsosceles(double side1, double side2, double side3) => 
        isTriangle(side1, side2, side3) &&
        new List<double> { side1, side2, side3 }.Distinct().Count() <= 2;

    public static bool IsEquilateral(double side1, double side2, double side3) => 
        isTriangle(side1, side2, side3) &&
        new List<double> { side1, side2, side3 }.Distinct().Count() == 1;

    private static bool isTriangle(double side1, double side2, double side3) =>
    (side1 + side2 > side3) &&
    (side2 + side3 > side1) &&
    (side1 + side3 > side2);
}