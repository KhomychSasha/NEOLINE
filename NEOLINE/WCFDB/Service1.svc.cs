using BLL;
using DAL.Entities;
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
        protected RealisationBLL bll = new RealisationBLL();

        public User UserInfo(string login)
        {
            return bll.UserInfo(login);
        }

        public Product ProductInfo(string productName, string userLogin)
        {
            return bll.ProductInfo(productName,userLogin);
        }

        public void ChangeUserNickname(string login, string nick)
        {
            bll.ChangeUserNickname(login,nick);
        }

        public void ChangeUserEmail(string login, string newEmail)
        {
            bll.ChangeUserEmail(login,newEmail);
        }

        public void ChangePass(string login, string pass)
        {
            bll.ChangeUserPass(login,pass);
        }

        public void AddUser(string login, string pass, string nick, string email)
        {
            bll.AddUser(login,pass,nick,email);
        }

        public void AddProduct(string productName, string descr, string photo, string login, int AmountOfProduct, int price)
        {
            bll.AddProduct(productName,descr,photo,login,AmountOfProduct,price);
        }

        public bool VerificationOnAdmin(string login, string pass)
        {
            return bll.VerificationOnAdmin(login,pass);
        }

        public bool VerificationOnExistUser(string login, string pass)
        {
            return VerificationOnExistUser(login,pass);
        }

        public bool VerificationLogin(string login)
        {
            return VerificationLogin(login);
        }

        public bool VerificationNickname(string nickname)
        {
            return VerificationNickname(nickname);
        }

        public bool VerificationEmail(string email)
        {
            return VerificationEmail(email);
        }

        public void UpdateProductPrice(string nameProduct, int price)
        {
            bll.UpdateProductPrice(nameProduct,price);
        }

        public void UpdateProductAmount(string nameProduct, int amountProduct)
        {
            bll.UpdateProductAmount(nameProduct,amountProduct);
        }

        public void UpdateProductDescription(string nameProduct, string description)
        {
            bll.UpdateProductDescription(nameProduct,description);
        }

        public List<Product> UserProduct(string login)
        {
            return bll.UserProduct(login);
        }

        public List<Product> WarehoseProductAddedByAdmin()
        {
            return bll.WarehoseProductAddedByAdmin();
        }

        public string UserNickname(string login)
        {
            return bll.UserNickname(login);
        }

        public string UserEmail(string login)
        {
            return bll.UserEmail(login);
        }

        public string UserProducts(string login)
        {
            return bll.UserProducts(login);
        }

        public void UpdateProductPhoto(string productName, string photo)
        {
            bll.UpdateProductPhoto(productName, photo);
        }

        public void UserUpdateAvatar(string login, string avatar)
        {
            bll.UserUpdateAvatar(login, avatar);
        }
    }
}
