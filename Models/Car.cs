using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gregslist.Models
{
  public class Car
  {
    public Car(string make, string model, int? year, string description)
    {
      Id = Guid.NewGuid().ToString();
      Make = make;
      Model = model;
      Year = year;
      Description = description;

    }
    public string Id { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public int? Year { get; set; }
    public string Description { get; set; }
  }
}