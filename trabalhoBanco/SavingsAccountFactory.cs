public class SavingsAccountFactory : AccountFactory
{
  public override Account CreateAccount(int accountNumber)
  {
    return new SavingsAccount(accountNumber);
  }
}