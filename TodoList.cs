using System;

namespace SavingInterface
{
  class TodoList : IDisplayable, IResetable
  {
    public string[] Todos
    { get; private set; }

    private int nextOpenIndex;

    public TodoList()
    {
      Todos = new string[5];
      nextOpenIndex = 0;
    }

    public void Add(string todo)
    {
      if(nextOpenIndex >4)
      {
        throw new ArgumentOutOfRangeException("Todo", "Maximum of Todos must be 5. Your last added have changed with new todo.");
      }
      else
      {Todos[nextOpenIndex] = todo;
      nextOpenIndex++;}
    }

    public void Display()
    {
      Console.WriteLine("\nTodos");
      Console.WriteLine("---------");
      foreach(var item in this.Todos)
      {
        if(item!=null)
          {Console.WriteLine(item);}
      
      }
    }

    public void Reset()
    {
      this.Todos = new string[5];
      this.nextOpenIndex = 0;
    }
  }
}