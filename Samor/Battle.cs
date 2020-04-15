using System;
using System.Collections.Generic;
using EntityFramework;

namespace Samor
{
    public class Battle
    {

        
        public int Id { set; get; }
        public string Name { set; get; }
        
        public DateTime StartDate { set; get; }=new DateTime();
        
        public DateTime EndDate { set; get; }=new DateTime();
    }
}