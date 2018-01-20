using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DBNeoline;
using DAL;
using System.Runtime.Serialization;
using System.Windows.Media.Imaging;

namespace BLL
{
    [DataContract]
    public class DTOUser
    {
        [DataMember]
        public int DTOId { get; set; }

        [DataMember]
        public string DTOLogin { get; set; }

        [DataMember]
        public string DTOPassword { get; set; }

        [DataMember]
        public string DTONickname { get; set; }

        [DataMember]
        public string DTOEmail { get; set; }

        [DataMember]
        public ICollection<Product> DTOProducts { get; set; }

        [DataMember]
        public bool DTOIsAdmin  { get; set; }

        [DataMember]
        public BitmapImage DTOAvatar { get; set; }
    }

    [DataContract]
    public class DTOProduct
    {
        [DataMember]
        public int DTOId { get; set; }

        [DataMember]
        public string DTOProductName { get; set; }

        [DataMember]
        public string DTODescription { get; set; }

        [DataMember]
        public BitmapImage DTOPhoto { get; set; }

        [DataMember]
        public int DTOAmount { get; set; }

        [DataMember]
        public int DTOPrice { get; set; }

        [DataMember]
        public int DTOUserID { get; set; }

        [DataMember]
        public virtual User DTOUsersProducts { get; set; }

        [DataMember]
        public int DTOCategoryID { get; set; }

        [DataMember]
        public virtual Category DTOCategories { get; set; }
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

        public DTOProduct ProdInfo(string productName, int userID)
        {
            Product prod = dal.ProductInfo(productName,userID);

            DTOProduct product = new DTOProduct()
            {
                DTOId = prod.Id,
                DTOProductName = prod.ProductName,
                DTODescription = prod.Description,
                DTOAmount = prod.Amount,
                DTOCategoryID = prod.CategoryID,
                DTOCategories = prod.Categories,
                DTOPhoto = prod.Photo,
                DTOPrice = prod.Price,
                DTOUserID = prod.UserID,
                DTOUsersProducts = prod.UserIDs
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

        public void AddProduct(string productName, string descr, BitmapImage photo, int ID, int AmountOfProduct, int price)
        {
            Product product = new Product()
            {
                ProductName = productName,
                Description = descr,
                Photo = photo,
                UserID = ID,
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

        public List<Product> UserProduct(int ID)
        {
            Product prod = new Product()
            {
                UserID = ID
            };

            return dal.UserProduct(prod);
        }

        public List<Product> WarehoseProductAddedByAdmin()
        {
            return dal.WarehoseProductAddedByAdmin();
        }

        public void UpdateProductPhoto(string productName, BitmapImage photo)
        {
            Product product = new Product()
            {
                ProductName = productName,
                Photo = photo
            };

            dal.UpdateProductPhoto(product);
        }

        public void UserUpdateAvatar(string login, BitmapImage avatar)
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