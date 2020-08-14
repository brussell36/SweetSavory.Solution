using System.Collections.Generic;

namespace SweetSavory.Models
{
  public class Treat
  {
    public Treat()
    {
      this.Flavors = new HashSet<FlavorTreat>();
    }
    public int TreatId { get; set; }
    public string Dish { get; set; }
    public ICollection<FlavorTreat> Flavors { get; set; }
  }
}