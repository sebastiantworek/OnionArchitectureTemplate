using DataModel.Entities;
using Persistence;
using System;
using System.Linq;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var  db = new EntityContext())
            {
                Console.WriteLine("Start");

                var master = new MasterEntitiy() { Attribute2 = "Master" };
                db.MasterEntities.Add(master);
                db.SaveChanges();

                var query = from m in db.MasterEntities where m.Id > 1 select m;

                Console.WriteLine("Masters:");
                foreach(var m in query)
                {
                    Console.WriteLine($"{m.Id}: {m.Attribute2}");
                }

                Console.WriteLine("End");
                Console.ReadLine();
            }
        }
    }
}
