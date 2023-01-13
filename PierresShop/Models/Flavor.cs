namespace PierresShop.Models 
{
  public class Flavor 
  {
    public string Name { get; set; }
    public int FlavorId { get; set; }
    public List<TreatFlavor> JoinEntities { get;}
    public ApplicationUser User { get; set; }
  }

}