public class CurrentAccountFactory : AccountFactory
{
  public override Account CreateAccount(int accountNumber)
  {
    return new CurrentAccount(accountNumber);
  }
}