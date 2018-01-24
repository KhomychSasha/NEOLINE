using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DBNeoline;

namespace CreateDB
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (OnlineShop shop = new OnlineShop())
                {
                    shop.Users.Add(new User() { Login = "dfh", Password = "Pass", Nickname = "dfh", Email = "sdh" });
                    shop.SaveChanges();
                }

                Console.WriteLine("DB successfully created");
            }
            catch(Exception e)
            {
                Console.WriteLine("DB is out because: "+e.Message);
            }

        }
    }
}
