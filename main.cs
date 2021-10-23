using System;

class Program {
  public static double CylinderVolume(double radius, double height)
  {
  double x = radius;
  double y = height;
  double volume = Convert.ToDouble(3.14 * x * x * y);
  return volume;
  }
  public static void Main (string[] args)
  {
    Console.WriteLine("Enter Cylinder Radius");
    double radius = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter Cylinder Height");
    double height = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Volume of Cylinder");
    double voulume = CylinderVolume(radius, height);
    Console.WriteLine(volume);
  }
}