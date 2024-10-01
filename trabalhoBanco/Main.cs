using System; 
using System.Collections.Generic; 


public class Program {

  public static void Main(string[] args) {
    Bank banco = new Bank("Banco do Brasil", 1);
    Branch branch = new Branch("Banco do Brasil", 1, "Rio de Janeiro");
    banco.addBranches(branch);
    banco.getBranch(1);
    AccountFactory savingsFactory = new SavingsAccountFactory();
    var savingsAccount = savingsFactory.CreateAccount(125040);
    savingsAccount.creditAmmount(5000);
    savingsAccount.getBalance();
    for(int i = 0; i < 5; i++)
    {
      savingsAccount.debitAmmount(100);
      savingsAccount.getBalance();
    }
    savingsAccount.virarMes();
    savingsAccount.debitAmmount(100);
    savingsAccount.getBalance();

  }
}