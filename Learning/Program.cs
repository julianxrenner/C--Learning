House myHouse = new House(10000, 2000);
House yourHouse = new House(5000, 2025);

Console.WriteLine(myHouse.YearBuilt);
Console.WriteLine(myHouse.Size);
Console.WriteLine(myHouse.CanBeSold());
Console.WriteLine(yourHouse.CanBeSold());

class House 
{
  public House(int sizeInSquareFeet, int yearBuilt)
  {
    Size = sizeInSquareFeet;
    YearBuilt = yearBuilt;
  }

  public int Size { get; set; }

  public int YearBuilt { get; set; }

  private int HowOld()
  {
    DateTime todaysDate = DateTime.Now;
    int thisYear = todaysDate.Year;
    int houseAge = thisYear - YearBuilt;
    return houseAge;
  }

  public bool CanBeSold()
  {
    if (HowOld() > 15)
    {
      return true;
    }
    else
    {
      return false;
    }
  }
}