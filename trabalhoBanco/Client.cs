using System;

public class Client
{
  public string name { get; set; }
  public string CPF { get; set; }
  public string address { get; set; }
  public string phone { get; set; }
  public string email { get; set; }

  public Client(string name, string CPF, string address,   string phone, string email)
    {
      this.name = name;
      this.CPF = CPF;
      this.address = address;
      this.phone = phone;
      this.email = email;
    }
}

