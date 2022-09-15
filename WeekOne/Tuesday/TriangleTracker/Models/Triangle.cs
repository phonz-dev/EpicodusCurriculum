namespace TriangleTracker.Models
{
  public class Triangle
  {
    private int Side1 { get; }
    private int Side2 { get; }
    private int Side3 { get; }

    public Triangle(int side1, int side2, int side3)
    {
      Side1 = side1;
      Side2 = side2;
      Side3 = side3;
    }

    public string DetermineTriangleType()
    {
      if (!IsValid()) return "Invalid triangle";

      if (IsEquilateral())
        return "Equilateral";
      else if (IsIsosceles())
        return "Isosceles";
      else
        return "Scalene";
    }

    private bool IsEquilateral()
      => Side1 == Side2 && Side1 == Side3;

    private bool IsIsosceles()
    {
      if ((Side1 == Side2 && Side1 != Side3) ||
        ((Side1 == Side3 || Side2 == Side3) && Side1 != Side2))
        return true;

      return false;
    }

    private bool IsValid()
    {
      if ((Side1 == Side2 && Side3 > (Side1 + Side2)) ||
        (Side1 == Side3 && Side2 > (Side1 + Side3)) ||
        (Side2 == Side3 && Side1 > (Side2 + Side3)))
        return false;

      return true;
    }
  }
}
