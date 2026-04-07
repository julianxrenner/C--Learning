

Account myAccount = new Account(123, 21);
Console.WriteLine(myAccount.Balance);

myAccount.DepositMoney(50);
Console.WriteLine(myAccount.Balance);

class Account
{
  public int IdentificationNumber { get; set; }
  public decimal Balance { get; set; }
  public Account(int identificationNumber, decimal balance)
  {
    IdentificationNumber = identificationNumber;
    Balance = balance;
  }

  public void DepositMoney(decimal depositAmount)
  {
    Balance += depositAmount;
  }

}