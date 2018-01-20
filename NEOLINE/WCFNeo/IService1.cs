using BLL;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Windows.Media.Imaging;

namespace WCFNeo
{
    public class Service1 : IService1
    {
        public RealisationBLL bll = new RealisationBLL();

        public DTOUser UserInfo(string login)
        {
            return bll.UsInfo(login);
        }

        public DTOProduct ProdInfo(string productName, int userID)
        {
            return bll.ProdInfo(productName, userID);
        }

        public void ChangeUserNickname(string login, string nick)
        {
            bll.ChangeUserNickname(login, nick);
        }

        public void ChangeUserEmail(string login, string newEmail)
        {
            bll.ChangeUserEmail(login, newEmail);
        }

        public void ChangePass(string login, string pass)
        {
            bll.ChangeUserPass(login, pass);
        }

        public void AddUser(string login, string pass, string nick, string email)
        {
            bll.AddUser(login, pass, nick, email);
        }

        public void AddProduct(string productName, string descr, BitmapImage photo, int userID, int AmountOfProduct, int price)
        {
            bll.AddProduct(productName, descr, photo, userID, AmountOfProduct, price);
        }

        public bool VerificationOnAdmin(string login, string pass)
        {
            return bll.VerificationOnAdmin(login, pass);
        }

        public bool VerificationOnExistUser(string login, string pass)
        {
            return VerificationOnExistUser(login, pass);
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
            bll.UpdateProductPrice(nameProduct, price);
        }

        public void UpdateProductAmount(string nameProduct, int amountProduct)
        {
            bll.UpdateProductAmount(nameProduct, amountProduct);
        }

        public void UpdateProductDescription(string nameProduct, string description)
        {
            bll.UpdateProductDescription(nameProduct, description);
        }

        public List<Product> UserProduct(int ID)
        {
            return bll.UserProduct(ID);
        }

        public List<Product> WarehoseProductAddedByAdmin()
        {
            return bll.WarehoseProductAddedByAdmin();
        }

        public void UpdateProductPhoto(string productName, BitmapImage photo)
        {
            bll.UpdateProductPhoto(productName, photo);
        }

        public void UserUpdateAvatar(string login, BitmapImage avatar)
        {
            bll.UserUpdateAvatar(login, avatar);
        }
    }
}
