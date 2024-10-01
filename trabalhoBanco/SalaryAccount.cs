using System;

public class SalaryAccount : Account
{
  public SalaryAccount(int accountNumber) : base(accountNumber){}

  public override void AccountType(){
    Console.WriteLine("This is a Salary Account.");
  }

  public override void fazerPix(Account account, float ammount)
  {
     Console.WriteLine("Não pode fazer Pix");
  }

  public override void render(float taxa)
  {
    Console.WriteLine("Não pode render");
  }
}