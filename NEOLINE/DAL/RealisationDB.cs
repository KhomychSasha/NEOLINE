using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBNeoline;
using DAL.Entities;

namespace DAL
{
    public class RealisationDB : IDAL
    {
        public void AddUser(User user)
        {
            using (OnlineShop shop = new OnlineShop())
            {
                shop.Users.Add(new User()
                {
                    Login = user.Login,
                    Password = user.Password,
                    Nickname = user.Nickname,
                    Email = user.Email
                });

                shop.SaveChanges();
            }
        }

        public void AddProduct(Product product)
        {
            using (OnlineShop shop = new OnlineShop())
            {
                shop.Products.Add(new Product()
                {
                    ProductName = product.ProductName,
                    Description = product.Description,
                    Photo = product.Photo,
                    UserLogin = product.UserLogin,
                    Amount = product.Amount,
                    Price = product.Price
                });

                shop.SaveChanges();
            }
        }

        public void UpdatePrice(Product product)
        {
            Product prod = null;

            using (OnlineShop shop = new OnlineShop())
            {
                prod = shop.Products.Where(c => c.ProductName == prod.ProductName).Single();

                prod.Price = prod.Price;
                shop.SaveChanges();
            }
        }

        public void UpdateAmount(string nameProduct, int amountProduct)
        {
            Product product = null;

            using (OnlineShop shop = new OnlineShop())
            {
                product = shop.Products.Where(c => c.ProductName == nameProduct).Single();

                product.Amount = amountProduct;
                shop.SaveChanges();
            }
        }

        public void UpdateDescription(string nameProduct, string description)
        {
            Product product = null;

            using (OnlineShop shop = new OnlineShop())
            {
                product = shop.Products.Where(c => c.ProductName == nameProduct).Single();

                product.Description = description;
                shop.SaveChanges();
            }
        }

        public bool VerificationOnAdmin(string login, string pass)
        {
            User user = null;
            bool IsUserExistAdmin = false;

            using (OnlineShop shop = new OnlineShop())
            {
                user = shop.Users.Where(c => c.Login == login && c.Password == pass).Single();
            }

            if (user.IsAdmin == true)
            {
                IsUserExistAdmin = true;
            }
            else
            {
                IsUserExistAdmin = false;
            }


            return IsUserExistAdmin;
        }

        public bool VerificationOnExistUser(string login, string pass)
        {
            User user = null;
            bool IsUserExistUser;

            try
            {
                using (OnlineShop shop = new OnlineShop())
                {
                    user = shop.Users.Where(c => c.Login == login && c.Password == pass).Single(); var result = shop.Products.Where(c => c.UserLogin == login);
                }
                IsUserExistUser = true;
            }
            catch (Exception)
            {
                IsUserExistUser = false;
            }

            return IsUserExistUser;
        }

        public List<Product> UserProduct(string login)
        {
            List<Product> list = new List<Product>();

            using (OnlineShop shop = new OnlineShop())
            {
                foreach (var i in shop.Products.Where(c => c.UserLogin == login))
                {
                    list.Add(i);
                }
            }

            return list;
        }

        public List<Product> WarehoseProductAddedByAdmin()
        {
            List<Product> list = new List<Product>();

            using (OnlineShop shop = new OnlineShop())
            {
                foreach (var i in shop.Products.Where(c => c.UserLogin == null))
                {
                    list.Add(i);
                }
            }

            return list;
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
            catch (Exception)
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
