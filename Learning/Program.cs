using System.Diagnostics.Contracts;

House myHouse = new House(10000, 2023);

Console.WriteLine(myHouse.ConstructionYear);
Console.WriteLine(myHouse.SquareFootage);
Console.WriteLine(myHouse.HowOld());
Console.WriteLine(myHouse.CanBeSold());

House myOtherHouse = new House(10000, 2010);

Console.WriteLine(myOtherHouse.CanBeSold());

class House 
{
  public House(int squareFootage, int constructionYear)
  {
    SquareFootage = squareFootage;
    ConstructionYear = constructionYear;
  }

  public int SquareFootage { get; set; }

  public int ConstructionYear { get; set; }

  public int HowOld() 
  {
    return 2026-ConstructionYear;
  }
  public bool CanBeSold()
  {
    return 2026 - ConstructionYear > 15;
  }
}