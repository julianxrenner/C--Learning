//Practicing extention methods

Person person1 = new Person("Julian", "Renner");
string person1Initials = person1.GetInitials();
Console.WriteLine($"{person1.FirstName}s initials are {person1Initials}");
public class Person
{
  public string FirstName { get; set; }

  public string LastName { get; set; }

  public Person(string firstName, string lastName)
  {
    FirstName = firstName;
    LastName = lastName;
  }
}

public static class NameExtentions
{
  public static string GetInitials(this Person person)
  {
    char firstInitial = person.FirstName[0];
    char secondInitial = person.LastName[0];
    return $"{firstInitial}{secondInitial}";
  }
}