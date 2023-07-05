namespace Restaurant
{
  public class CannedDrink : IDrink
  {
    public CannedDrink(string title)
    {
      Title = title; 
    }

    public int Id { get; private set; }
    public string Title { get; private set; }

    public void Drink()
    {
      Console.WriteLine($"Opened tab. Now I'm drinking my {Title} canned drink");
    }
  }
}