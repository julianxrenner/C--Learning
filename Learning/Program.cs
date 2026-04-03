while (true)
{
  Console.WriteLine("Enter a number:");
  string? firstVal = Console.ReadLine();
  int val1 = Int32.Parse(firstVal);
  Console.WriteLine("Enter another number:");
  string? secVal = Console.ReadLine();
  int val2 = Int32.Parse(secVal);
  Console.WriteLine("Enter an operator");
  string? op = Console.ReadLine();

  int total = 0;

  switch (op)
  {
    case "+":
      total = val1 + val2;
      break;
    case "-":
      total = val1 - val2;
      break;
    case "/":
      total = val1 / val2;
      break;
    case "*":
      total = val1 * val2;
      break;
    default:
      break;
  }

  Console.WriteLine($"The Result is: {total}");
  Console.WriteLine("Would you like to calculate again? say \"no\" to stop.");
  string? ans = Console.ReadLine();
  if (ans == "no"){
    Console.WriteLine("Oh man... Bye Bye.");
    break;
  }else{
    continue;
  }
}

