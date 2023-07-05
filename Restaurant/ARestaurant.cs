using Shared;

namespace Restaurant
{
  public class Restaurante : Establishment
  {

    public int Id { get; private set; }
    public string Title { get; set; }
    public Owner Owner { get; private set; }
    public List<IRestaurantWorker> Workers {get; private set;} = new List<IRestaurantWorker>();

    // public Dictionary<>
    private void Work(){

    }

    private bool IsStaffAvailable(){
      return false;
    }
    public void Open(int ownerId)
    {
      if (ownerId == Owner.Id)
      {
        if(IsStaffAvailable()){
          Work();
          Console.WriteLine($"The restaurant {Title} is now open to serve.");
        }
        Console.WriteLine($"The restaurant {Title} doesn't have enough workers to open.");
        
      }

      Console.WriteLine($"You're not the owner, you can't open the restaurant {Title}");
      return;
    }
    public void Close(int ownerId)
    {
      if (ownerId == Owner.Id)
      {
        Console.WriteLine($"The restaurant {Title} is now open to serve.");
        return;
      }

      Console.WriteLine($"You're not the owner, you can't close the restaurant {Title}");
      return;
    }
  }
}