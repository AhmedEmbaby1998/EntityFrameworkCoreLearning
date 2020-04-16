using System;
using System.Collections.Generic;
using EntityFramework;
using Microsoft.EntityFrameworkCore.Design;

namespace Samor
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://docs.microsoft.com/en-us/ef/core/miscellaneous/logging?tabs=v3
//
//https://app.pluralsight.com/course-player?clipId=7f003175-2f06-4820-ae3b-90fa38a8a957
            using (var c = new SamoraiContext())
            {
                var os = new List<Clan>();
                for (int i = 0; i < 3; i++)
                {
                    os.Add(new Clan()
                    {
                        ClanName =$"Ahmed {(char) i}"
                    });
                }
                c.Clans.AddRange(os);
                c.SaveChanges();
            }

        }

     
    }
}