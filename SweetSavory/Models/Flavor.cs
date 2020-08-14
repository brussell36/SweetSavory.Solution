using System.Collections.Generic;

namespace SweetSavory.Models
{
  public class Flavor
  {
    public Flavor()
    {
      this.Treats = new HashSet<FlavorTreat>();
    }
    public int FlavorId { get; set; }
    public string Taste { get; set; }
    public ICollection<FlavorTreat> Treats { get; set; }
  }
}