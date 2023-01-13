namespace PierresShop.Models 
{
  public class Treat 
  {
    public string Name { get; set; }
    public int TreatId { get; set; }
    public List<TreatFlavor> JoinEntities { get;}
  }

}