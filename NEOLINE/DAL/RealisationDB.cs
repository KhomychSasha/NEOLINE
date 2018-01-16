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

        public void UpdateProductPrice(Product product)
        {
            Product prod = null;

            using (OnlineShop shop = new OnlineShop())
            {
                prod = shop.Products.Where(c => c.ProductName == prod.ProductName).Single();

                prod.Price = product.Price;
                shop.SaveChanges();
            }
        }

        public void UpdateProductAmount(Product product)
        {
            Product prod = null;

            using (OnlineShop shop = new OnlineShop())
            {
                prod = shop.Products.Where(c => c.ProductName == product.ProductName).Single();

                prod.Amount = product.Amount;
                shop.SaveChanges();
            }
        }

        public void UpdateProductDescription(Product product)
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

        public User UserInfo(User user)
        {
            User us = null;

            using (OnlineShop shop = new OnlineShop())
            {
                us = shop.Users.Where(c => c.Login == user.Login).Single();
            }

            return us;
        }

        public void UpdateProductPhoto(Product prod)
        {
            Product product = null;

            using (OnlineShop shop = new OnlineShop())
            {
                product = shop.Products.Where(c => c.ProductName == prod.ProductName).Single();

                product.Price = prod.Price;
                shop.SaveChanges();
            }
        }

        public void UserUpdateAvatar(User user)
        {
            User us = null;

            using (OnlineShop shop = new OnlineShop())
            {
                us = shop.Users.Where(c => c.Login == user.Login).Single();

                us.Avatar = user.Avatar;
                shop.SaveChanges(); 
            }
        }

        public void ChangeUserPass(User user)
        {
            User us = null;

            using (OnlineShop shop = new OnlineShop())
            {
                us = shop.Users.Where(c => c.Login == user.Login).Single();

                us.Password = user.Password;
                shop.SaveChanges();
            }
        }

        public void ChangeUserEmail(User user)
        {
            User us = null;

            using (OnlineShop shop = new OnlineShop())
            {
                us = shop.Users.Where(c => c.Login == user.Login).Single();

                us.Email = user.Email;
                shop.SaveChanges();
            }
        }

        public void ChangeUserNickname(User user)
        {
            User us = null;

            using (OnlineShop shop = new OnlineShop())
            {
                us = shop.Users.Where(c => c.Login == user.Login).Single();

                us.Nickname = user.Nickname;
                shop.SaveChanges();
            }
        }

        public Product ProductInfo(Product prod)
        {
            Product pr = null;

            using (OnlineShop shop = new OnlineShop())
            {
                pr = shop.Products.Where(c => c.ProductName == prod.ProductName && c.UserLogin == prod.UserLogin).Single();
            }
            
            return pr;
        }
    }
}
