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

            }

            shop.SaveChanges();
            base.Seed(shop);
        }
    }
}
