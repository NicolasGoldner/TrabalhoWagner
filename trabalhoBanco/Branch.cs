using System;
using System.Collections.Generic; 

public class Branch
{
  public string name { get; set; }
  public int code { get; set; }
  public string city { get; set; }
  List<Account> accounts = new List<Account>();

  public Branch (string name, int code, string city)
  {
    this.name = name;
    this.code = code;
    this.city = city;
  }

  public void addAccount(Account account)
  {
    accounts.Add(account);
  }

  public void removeAccount(Account account)
  {
    accounts.Remove(account);
  }
  
  public Account getAccount(int Acc_number)
  {
    foreach(Account account in accounts)
    {
      if (account.Acc_number == Acc_number)
      {
        return account;
      }
    }
    return null;
  }
}