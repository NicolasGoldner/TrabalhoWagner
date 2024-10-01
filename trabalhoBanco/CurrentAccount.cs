using System;

public class CurrentAccount : Account
{
  public CurrentAccount(int accountNumber) : base(accountNumber){}

  public override void AccountType(){
    Console.WriteLine("This is a Current Account.");
  }

  public override void render(float taxa)
  {
    Console.WriteLine("Não pode render");
  }
}