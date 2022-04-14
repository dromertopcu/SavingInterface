using System;

namespace SavingInterface
{
  class Program
  {
    static void Main(string[] args)
    {
      TodoList tdl = new TodoList();
      tdl.Add("Invite friends");
      tdl.Add("Buy decorations");
      tdl.Add("Party");
      tdl.Add("dene");
      tdl.Add("öyle");

      PasswordManager pm = new PasswordManager("iluvpdsie", true);

      tdl.Display();
      pm.Display();
      pm.ChangePassword("iluvpdsie","deneme123");
      pm.Show();
      pm.Display();
      tdl.Reset();
      pm.Reset();
      tdl.Display();
      pm.Display();
    }
  }
}
