using System;

public abstract class Account
{
  public int Acc_number { get; set; }
  protected float balance { get; set;}
  public string date { get; set; }

  public Account(int accountNumber)
  {
    Acc_number = accountNumber;
    balance = 0.0F;
  }
  public virtual void virarMes(){}
  public abstract void AccountType();

  public virtual void debitAmmount(float ammount)
  {
    if(balance - ammount >= 0 && ammount > 0)
    {
      balance -= ammount;
    }else
    {
      Console.WriteLine("Saldo insuficiente");
    }
  }

  public virtual void creditAmmount(float ammount)
  {
    if(ammount > 0)
    {
      balance += ammount;
    }
  }

  public virtual float getBalance()
  {
    Console.WriteLine("Saldo de: " + this.balance + " Reais");
    return balance;
  }

  public virtual void transfer(Account account, float ammount)
  {
    if(this.balance - ammount >= 0 && ammount > 0)
    {
      account.creditAmmount(ammount);
    }
  }

  public virtual void fazerPix(Account account, float ammount)
  {
    if(this.balance - ammount >= 0 && ammount > 0)
    {
      account.creditAmmount(ammount);
    }
  }
  public virtual void render(float taxa)
  {
    this.balance += this.balance * (taxa / 100) * 1;
  }
  
  
  
}

