
List<Race> calendar = new List<Race>();

DateTime firstRaceDate = new DateTime(2025, 4, 25);
DateTime secondRaceDate = new DateTime(2025, 5, 5);
DateTime thirdRaceDate = new DateTime(2025, 5, 15);

Race firstRace = new Race("America Race", firstRaceDate, "Miami Circuit");
Race secondRace = new Race("Asia Race", secondRaceDate, "Suzuka");
Race thirdRace = new Race("Middle East Race", thirdRaceDate, "Bahrain International Circuit");

calendar.Add(firstRace);
calendar.Add(secondRace);
calendar.Add(thirdRace);

foreach(var race in calendar)
{
  Console.WriteLine($"{race.Name} will be hosted at {race.TrackName} on the date of {race.Date}");
}

Driver driver1 = new Driver("Verstappen");
firstRace.AddDriverToRaceGrid(driver1);
firstRace.AddDriverToRaceGrid(driver1);

foreach(var driver in firstRace.StartingGrid)
{
  Console.WriteLine($"{driver.Name} is in {firstRace.Name}");
}

class Race
{
  public string Name { get; set; }

  public string TrackName { get; set; }

  public DateTime Date { get; set; }

  public List<Driver> StartingGrid {get; private set;}= new List<Driver>();
  public Race(string name, DateTime date, string trackName)
  {
    Name = name;
    Date = date;
    TrackName = trackName;
  }

  public void AddDriverToRaceGrid(Driver driver)
  {
    if (StartingGrid.Count < 20 && !StartingGrid.Contains(driver))
    {
      StartingGrid.Add(driver);
      Console.WriteLine("Driver Successfully Added to Race");
    }
    else
    {
      Console.WriteLine("Race is full or the driver has already been added");
    }
  }
}

class Driver
{

  public string Name { get; set; }
  public Driver(string name)
  {
    Name = name;
  }
}