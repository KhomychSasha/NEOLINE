using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DBNeoline;
using DAL;

namespace BLL
{
    public class RealisationBLL : IBLL
    {
        public IDAL dal = new RealisationDB();

        public void AddUser(string login, string pass, string nick, string email)
        {
            User user = new User()
            {
                Login = login,
                Password = pass,
                Nickname = nick,
                Email = email
            };

            dal.AddUser(user);
        }

        public void AddProduct(string productName, string descr, string photo, string login, int AmountOfProduct, int price)
        {
            Product product = new Product()
            {
                ProductName = productName,
                Description = descr,
                Photo = photo,
                UserLogin = login,
                Amount = AmountOfProduct,
                Price = price
            };

            dal.AddProduct(product);
        }

        public bool VerificationOnAdmin(string login, string pass)
        {
            User user = new User()
            {
                Login = login,
                Password = pass
            };

            return dal.VerificationOnAdmin(user);
        }

        public bool VerificationOnExistUser(string login, string pass)
        {
            User user = new User()
            {
                Login = login,
                Password = pass
            };

            return dal.VerificationOnExistUser(user);
        }

        public bool VerificationLogin(string login)
        {
            User user = new User()
            {
                Login = login,
            };

            return dal.VerificationLogin(user);
        }

        public bool VerificationNickname(string nickname)
        {
            User user = new User()
            {
                Nickname = nickname,
            };

            return dal.VerificationNickname(user);
        }

        public bool VerificationEmail(string email)
        {
            User user = new User()
            {
                Email = email,
            };

            return dal.VerificationEmail(user);
        }

        public void UpdateProductPrice(string nameProduct, int price)
        {
            Product product = new Product()
            {
                ProductName = nameProduct,
                Price = price
            };

            dal.UpdateProductPrice(product);      
        }

        public void UpdateProductAmount(string nameProduct, int amountProduct)
        {
            Product product = new Product()
            {
                ProductName = nameProduct,
                Amount = amountProduct
            };

            dal.UpdateProductAmount(product);
        }

        public void UpdateProductDescription(string nameProduct, string description)
        {
            Product product = new Product()
            {
                ProductName = nameProduct,
                Description = description
            };

            dal.UpdateProductDescription(product);
        }

        public List<Product> UserProduct(string login)
        {
            Product prod = new Product()
            {
                UserLogin = login
            };

            return dal.UserProduct(prod);
        }

        public List<Product> WarehoseProductAddedByAdmin()
        {
            return dal.WarehoseProductAddedByAdmin();
        }

        public string UserNickname(string login)
        {
            User user = new User()
            {
                Login = login
            };

            return dal.UserNickname(user);
        }

        public string UserEmail(string login)
        {
            User user = new User()
            {
                Login = login
            };

            return dal.UserEmail(user);
        }

        public string UserProducts(string login)
        {
            User user = new User()
            {
                Login = login
            };

            return dal.UserProducts(user);
        }

        public string UserAvatar(string login)
        {
            User user = new User()
            {
                Login = login
            };

            return dal.UserAvatar(user);
        }

        public void UpdateProductPhoto(string productName, string photo)
        {
            Product product = new Product()
            {
                ProductName = productName,
                Photo = photo
            };

            dal.UpdateProductPhoto(product);
        }

        public void UserUpdateAvatar(string login, string avatar)
        {
            User user = new User()
            {
                Login = login,
                Avatar = avatar
            };

            dal.UserUpdateAvatar(user);
        }
    }
}
