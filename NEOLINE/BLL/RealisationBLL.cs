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
    
    public class DTOUser
    {
        public int DTOId { get; set; }

        public string DTOLogin { get; set; }

        public string DTOPassword { get; set; }

        public string DTONickname { get; set; }

        public string DTOEmail { get; set; }

        public ICollection<Product> DTOProducts { get; set; }

        public bool DTOIsAdmin  { get; set; }
        
        public string DTOAvatar { get; set; }
    }

    public class DTOProduct
    {
        public int Id { get; set; }

        public string ProductName { get; set; }

        public string Description { get; set; }

        public string Photo { get; set; }

        public int Amount { get; set; }

        public int Price { get; set; }

        public string UserLogin { get; set; }

        public virtual User UsersProducts { get; set; }

        public string CategoryName { get; set; }

        public virtual Category Categories { get; set; }
    }



    public class RealisationBLL : IBLL
    {
        public IDAL dal = new RealisationDB();

        public DTOUser UsInfo(string login)
        {
            User user = dal.UserInfo(login);

            DTOUser us = new DTOUser()
            {
                DTOId = user.Id,
                DTOLogin = user.Login,
                DTOPassword = user.Password,
                DTONickname = user.Nickname,
                DTOEmail = user.Email,
                DTOAvatar = user.Avatar,
                DTOIsAdmin = user.IsAdmin,
                DTOProducts = user.Products
            };

            return us;
        }

        public DTOProduct ProdInfo(string productName, string userLogin)
        {
            Product prod = dal.ProductInfo(productName,userLogin);

            DTOProduct product = new DTOProduct()
            {
                Id = prod.Id,
                ProductName = prod.ProductName,
                Description = prod.Description,
                Amount = prod.Amount,
                CategoryName = prod.CategoryName,
                Categories = prod.Categories,
                Photo = prod.Photo,
                Price = prod.Price,
                UserLogin = prod.UserLogin,
                UsersProducts = prod.UsersProducts
            };

            return product;
        }

        public void ChangeUserNickname(string login,string nick)
        {
            User user = new User()
            {
                Login = login,
                Nickname = nick
            };

            dal.ChangeUserNickname(user);
        }

        public void ChangeUserEmail(string login, string newEmail)
        {
            User user = new User()
            {
                Login = login,
                Email = newEmail
            };

            dal.ChangeUserEmail(user);
        }

        public void ChangeUserPass(string login, string pass)
        {
            User user = new User()
            {
                Login = login,
                Password = pass
            };

            dal.ChangeUserPass(user);
        }

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
