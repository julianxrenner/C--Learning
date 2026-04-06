Person person1 = new Person("Julian");
Person person2 = new Person("Renenr");

Console.WriteLine(person1.Name);

class Person
{

  public Person(string name)
  {
    Name = name;
  }

  public string Name { get; set; }

}