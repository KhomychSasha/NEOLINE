using DBNeoline;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class MyInitializer<T> : DropCreateDatabaseIfModelChanges<OnlineShop>
    {
        protected override void Seed(OnlineShop shop)
        {
            using (OnlineShop OS = new OnlineShop())
            {
                OS.Users.Add(new Entities.User() {Login = "dfh", Password = "Pass",Nickname = "dfh",Email = "sdh"});
            }

            shop.SaveChanges();
            base.Seed(shop);
        }
    }
}
