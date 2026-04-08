

Account regularAccount = new Account(123, 210, false);
Account premiumAccount = new Account(456, 210, true);

Console.WriteLine($"Regular Checking Account: {regularAccount.Balance}");
Console.WriteLine($"Premium Checking Account: {premiumAccount.Balance}");

regularAccount.AddInterest();
premiumAccount.AddInterest();

Console.WriteLine($"Regular Checking Account After Interest: {regularAccount.Balance}");
Console.WriteLine($"Premium Checking Account After Interest: {premiumAccount.Balance}");

regularAccount.TransferMoney(200m, premiumAccount);

Console.WriteLine($"Regular Checking Account After Transfer: {regularAccount.Balance}");
Console.WriteLine($"Premium Checking Account After Transfer: {premiumAccount.Balance}");

class Account
{
  public int IdentificationNumber { get; set; }
  public decimal Balance { get; set; }

  public bool IsPremium { get; set; }

  public decimal InterestRate { get; }
  public Account(int identificationNumber, decimal balance, bool isPremium)
  {
    IdentificationNumber = identificationNumber;
    Balance = balance;
    IsPremium = isPremium;
    InterestRate = isPremium ? 0.03m : 0.02m;
  }

  public void DepositMoney(decimal depositAmount)
  {
    Balance += depositAmount;
  }
  public void AddInterest()
  {
    Balance += Balance * InterestRate;
  }

  private void CheckIfTransferIsValid(decimal transferAmount, Account receivingAccount)
  {
    if(receivingAccount == null)
      throw new ArgumentNullException(nameof(receivingAccount), "Receiving account does not exist");
    if (Balance < transferAmount)
      throw new InvalidOperationException("Insufficient funds in sending account");
  }

  public void TransferMoney(decimal transferAmount, Account receivingAccount)
  {
    CheckIfTransferIsValid(transferAmount, receivingAccount);
    Balance -= transferAmount;
    receivingAccount.DepositMoney(transferAmount);
  }

}