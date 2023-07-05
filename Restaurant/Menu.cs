using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant
{
  public class Menu
  {

    public Menu()
    {

    }
    public int Id { get; private set; }
    public int RestaurantId { get; private set; }
    public Restaurante Restaurant { get; private set; }
    public Dictionary<int, IDrink> Drinks { get; private set; }
    public Dictionary<int, IMeal> Meals { get; private set; }
    public DateOnly Date { get; private set; }

    public void AddDrink(IDrink drink)
    {
      Drinks.Add(drink.Id, drink);
    }

    public void AddMeal(IMeal meal)
    {
      Meals.Add(meal.Id, meal);
    }

    public void DisplayDrinks()
    {
      // for(int i=)
    }


  }
}