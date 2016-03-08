using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DomainModel;

namespace ConsoleEFW
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new NorthwindContext())
            {
                //db.Database.Log
                foreach (var order in db.Orders)
                {
                    Console.WriteLine(order.Id);
                }
            }
        }
    }
}
