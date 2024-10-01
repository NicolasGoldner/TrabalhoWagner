using System;

public class SavingsAccount : Account
{
  public SavingsAccount(int accountNumber) : base(accountNumber){}
  public static int saques { get; set; }
  public override void AccountType(){
    Console.WriteLine("This is a Savings Account.");
  }

  public override void virarMes()
  {
    saques = 0;
  }

  public override void debitAmmount(float ammount)
  {
    if(balance - ammount >= 0 && ammount > 0 && saques <= 2)
    {
      balance -= ammount;
      saques++;
    }else if (balance - ammount >= 0 && ammount > 0 && saques >= 3)
    {
      balance = (balance - ammount) - 1;
      saques++;
    }
    else
    {
      Console.WriteLine("Saldo insuficiente");
    }
  }

  public override void fazerPix(Account account, float ammount)
  {
     Console.WriteLine("Não é possível fazer Pix com conta poupança.");
  }
  
}