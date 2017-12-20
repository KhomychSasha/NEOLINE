using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFForOnlineShopCenter
{
    public class Service1 : IService1
    {
        public void RegistrationUser(string login, string pass, string nick, string email)
        {
            using (OnlineShop user = new OnlineShop())
            {
                user.Users.Add(new User()
                {
                    Login = login,
                    Password = pass,
                    Nickname = nick,
                    Email = email
                });

                user.SaveChanges();
            }
        }

        public void AddProduct(string productName, string descr, string photo)
        {
            using (OnlineShop user = new OnlineShop())
            {
                user.Products.Add(new Product()
                {
                    ProductName = productName,
                    Description = descr,
                    Photo = photo
                });

                user.SaveChanges();
            }
        }

        public void AddAdmin(string login, string pass, string email)
        {
            using (OnlineShop user = new OnlineShop())
            {
                user.Admins.Add(new Admin()
                {
                    Login = login,
                    Password = pass,
                    Email = email
                });

                user.SaveChanges();
            }
        }
    }
}
