namespace EntityFramework
{
    public class Quote
     {
         public int Id { set; get; }
         
         public string Name { set; get; }
         
         public Samorai Samorai { set; get; }
         
         public int SamoraiId { set; get; }
     }
 }