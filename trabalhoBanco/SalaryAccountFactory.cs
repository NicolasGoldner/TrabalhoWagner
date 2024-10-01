public class SalaryAccountFactory : AccountFactory
{
  public override Account CreateAccount(int accountNumber)
  {
    return new SalaryAccount(accountNumber);
  }
}