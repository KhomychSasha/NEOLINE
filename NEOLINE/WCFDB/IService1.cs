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
    [ServiceContract]
    public interface IService1
    {
        void AddUser(string login, string pass, string nick, string email);

        void AddProduct(string productName, string descr, string photo, string login, int AmountOfProduct, int price);

        bool VerificationOnAdmin(string login, string pass);

        bool VerificationOnExistUser(string login, string pass);

        bool VerificationLogin(string login);

        bool VerificationNickname(string nickname);

        bool VerificationEmail(string email);

        void UpdateProductPrice(string nameProduct, int price);

        void UpdateProductAmount(string nameProduct, int amountProduct);

        void UpdateProductDescription(string nameProduct, string description);

        List<Product> UserProduct(string login);

        List<Product> WarehoseProductAddedByAdmin();

        string UserNickname(string login);

        string UserEmail(string login);

        string UserProducts(string login);

        void UpdateProductPhoto(string productName, string photo);

        void UserUpdateAvatar(string login, string avatar);

        void ChangePass(string login, string pass);

        void ChangeUserEmail(string login, string newEmail);

        void ChangeUserNickname(string login, string nick);
    }
}
