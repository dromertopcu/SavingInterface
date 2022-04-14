using System;

namespace SavingInterface
{
  class PasswordManager : IDisplayable, IResetable
  {
    private string password;
    private string Password
    { 
      get
      {
        return this.password;
      }
      set
      {
        if(value.Length>=8 )
        {
          this.password = value;
        }
        else
        {
          throw new ArgumentOutOfRangeException("Password", "Password must be at least 8 characters. Your password didn't change.");
        }
      }  
    }

    public bool Hidden
    { get; private set; }

    public PasswordManager(string password, bool hidden)
    {
      Password = password;
      Hidden = hidden;
    }

    public void Display()
    {
      Console.WriteLine("\nPassword");
      Console.WriteLine("------------");
      if(Hidden == false)
        Console.WriteLine(Password);
      else
        Console.WriteLine("***");
    }

    public void Show()
    {
      this.Hidden = false;
    }
    public void Reset()
    {
      this.Password = "12345678";
      this.Hidden = false;
    }

    public bool ChangePassword(string oldPassword, string newPassword)
    {
      if(this.Password == oldPassword)
      {
        this.Password = newPassword;
        return true; 
      }
      return false;
    }
  }
}