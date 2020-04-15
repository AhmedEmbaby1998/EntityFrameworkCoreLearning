using System.Collections.Generic;
using Samor;

namespace EntityFramework
{
    public class Samorai
    {
        public Samorai()
        {
            Quotes=new List<Quote>();
            BattlesFought=new List<SamoraiBattle>();
        }
        public int Id { set; get; }
        public string Name { set; get; }
        
        public string Address { set; get; }
        public  List<Quote> Quotes { set; get; }
        public Clan Clan { set; get; }
        
        public  List<SamoraiBattle> BattlesFought { set; get; }
        
        public Hourse Hourse { set; get; }
    }
}