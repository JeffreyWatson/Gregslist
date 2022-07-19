using System.Collections.Generic;
using Gregslist.Models;

namespace Gregslist.db
{
  public static class FakeDb
  {
    public static List<Car> Cars { get; set; } = new List<Car>(){
      new Car("Ford", "F150", 1994, "This truck is dope."),
      new Car("Lambo", "Gallardo", 2010, "Vroom Vroom"),
      new Car("Chrysler", "Town and Country", 2013, "Family commuter"),
    };
  }
}