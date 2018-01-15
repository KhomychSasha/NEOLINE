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

                prod.Price = product.Price;
                shop.SaveChanges();
            }
        }

        public void UpdateAmount(Product product)
        {
            Product prod = null;

            using (OnlineShop shop = new OnlineShop())
            {
                prod = shop.Products.Where(c => c.ProductName == product.ProductName).Single();

                prod.Amount = product.Amount;
                shop.SaveChanges();
            }
        }

        public void UpdateDescription(Product product)
        {
            Product prod = null;

            using (OnlineShop shop = new OnlineShop())
            {
                prod = shop.Products.Where(c => c.ProductName == product.ProductName).Single();

                prod.Description = product.Description;
                shop.SaveChanges();
            }
        }

        public bool VerificationOnAdmin(User user)
        {
            User US = null;
            bool IsUserExistAdmin = false;

            using (OnlineShop shop = new OnlineShop())
            {
                US = shop.Users.Where(c => c.Login == user.Login && c.Password == user.Password).Single();
            }

            if (US.IsAdmin == true)
            {
                IsUserExistAdmin = true;
            }
            else
            {
                IsUserExistAdmin = false;
            }


            return IsUserExistAdmin;
        }

        public bool VerificationOnExistUser(User user)
        {
            User US = null;
            bool IsUserExistUser;

            try
            {
                using (OnlineShop shop = new OnlineShop())
                {
                    US = shop.Users.Where(c => c.Login == user.Login && c.Password == user.Password).Single();
                }

                IsUserExistUser = true;
            }

            catch (Exception)
            {
                IsUserExistUser = false;
            }

            return IsUserExistUser;
        }

        public List<Product> UserProduct(Product product)
        {
            List<Product> list = new List<Product>();

            using (OnlineShop shop = new OnlineShop())
            {
                foreach (var i in shop.Products.Where(c => c.UserLogin == product.UserLogin))
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

        public bool VerificationLogin(User user)
        {
            User US = null;
            bool LoginVerified;

            try
            {
                using (OnlineShop shop = new OnlineShop())
                {
                    US = shop.Users.Where(c => c.Login == user.Login).Single();
                }

                LoginVerified = true;
            }
            catch (Exception)
            {
                LoginVerified = false;
            }

            return LoginVerified;
        }

        public bool VerificationNickname(User user)
        {
            User US = null;
            bool NickNameVerified;

            try
            {
                using (OnlineShop shop = new OnlineShop())
                {
                    US = shop.Users.Where(c => c.Nickname == user.Nickname).Single();
                }
                NickNameVerified = true;
            }
            catch (Exception)
            {
                NickNameVerified = false;
            }

            return NickNameVerified;
        }

        public bool VerificationEmail(User user)
        {
            User US = null;
            bool EmailVerified;

            try
            {
                using (OnlineShop shop = new OnlineShop())
                {
                    US = shop.Users.Where(c => c.Email == user.Email).Single();
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
