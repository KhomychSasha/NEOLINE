﻿using System;
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
            using (OnlineShop shop = new OnlineShop())
            {
                shop.Users.Add(new User()
                {
                    Login = login,
                    Password = pass,
                    Nickname = nick,
                    Email = email
                });

                shop.SaveChanges();
            }
        }

        public void AddProduct(string productName, string descr, string photo)
        {
            using (OnlineShop shop = new OnlineShop())
            {
                shop.Products.Add(new Product()
                {
                    ProductName = productName,
                    Description = descr,
                    Photo = photo
                });

                shop.SaveChanges();
            }
        }

        public string LoginUserEnter(string login, string pass)
        {
            User user = null;
            string IsUserExistKind;

            try
            {
                using (OnlineShop shop = new OnlineShop())
                {
                    user = shop.Users.Where(c => c.Login == login && c.Password == pass).Single();
                }

                if (user.IsAdmin == true)
                {
                    IsUserExistKind = "Admin";
                }
                else
                {
                    IsUserExistKind = "User";
                }
            }
            catch (Exception)
            {
                IsUserExistKind = "Your login or password isn`t exist or you don`t registred.Do you want register now.";
            }

            return IsUserExistKind;
        }

        public bool VerificationLogin(string login)
        {
            User user = null;
            bool LoginVerified;
            try
            {
                using (OnlineShop shop = new OnlineShop())
                {
                    user = shop.Users.Where(c => c.Login == login).Single();
                }
                LoginVerified = true;
            }
            catch (Exception)
            {
                LoginVerified = false;
            }

            return LoginVerified;
        }

        public bool VerificationNickname(string nickname)
        {
            User user = null;
            bool NickNameVerified;
            try
            {
                using (OnlineShop shop = new OnlineShop())
                {
                    user = shop.Users.Where(c => c.Nickname == nickname).Single();
                }
                NickNameVerified = true;
            }
            catch(Exception)
            {
                NickNameVerified = false;
            }

            return NickNameVerified;
        }

        public bool VerificationEmail(string email)
        {
            User user = null;
            bool EmailVerified;

            try
            {
                using (OnlineShop shop = new OnlineShop())
                {
                    user = shop.Users.Where(c => c.Email == email).Single();
                }
                EmailVerified = true;
            }
            catch (Exception)
            {
                EmailVerified = false;
            }

            return EmailVerified;
        }
    }
}
