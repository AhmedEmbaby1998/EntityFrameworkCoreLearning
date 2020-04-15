using System.ComponentModel.DataAnnotations.Schema;
using EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace Samor
{
    public class SamoraiBattle
    {
        public int Id { set; get; }
        public int BattleId { set; get; }
        public int SamoraiId { set; get; }
        
        public Battle Battle { set; get; }
        
        public Samorai Samorai { set; get; }
      
        
    }
}