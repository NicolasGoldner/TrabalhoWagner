using System;
using System.Collections.Generic; 

public class Bank
{
  public string name { get; set; }
  public int code { get; set; }
  List<Branch> branches = new List<Branch>();
  List<Client> clientes = new List<Client>();

  public Bank(string name, int code)
  {
    this.name = name;
    this.code = code;
  }

  public void addBranches(Branch branch)
  {
    branches.Add(branch);
  }

  public void removeBranches(Branch branch)
  {
    branches.Remove(branch);
  }

  public List<Branch> getBranches()
  {
    return branches;
  }

  public Branch getBranch(int code)
  {
    foreach(Branch branch in branches)
    {
      if (branch.code == code)
      {
        Console.WriteLine("Branch achada: " + branch.name);
        return branch;
      }
    }
    return null;
  }


  public void addClient(Client client)
  {
    clientes.Add(client);
  }

  public Client getClient(string cpf)
  {
    foreach(Client client in clientes)
    {
      if (client.CPF == cpf)
      {
        Console.WriteLine("Cliente achado: " + client.name);
        return client;
      }
    }
    return null;
  }


  
}