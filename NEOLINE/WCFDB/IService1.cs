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
        [OperationContract]
        void AddUser(string login, string pass, string nick, string email);

        [OperationContract]
        void AddProduct(string productName, string descr, string photo, string login, int AmountOfProduct, int price);

        [OperationContract]
        bool VerificationOnAdmin(string login, string pass);

        [OperationContract]
        bool VerificationOnExistUser(string login, string pass);

        [OperationContract]
        bool VerificationLogin(string login);

        [OperationContract]
        bool VerificationNickname(string nickname);

        [OperationContract]
        bool VerificationEmail(string email);

        [OperationContract]
        void UpdateProductPrice(string nameProduct, int price);

        [OperationContract]
        void UpdateProductAmount(string nameProduct, int amountProduct);

        [OperationContract]
        void UpdateProductDescription(string nameProduct, string description);

        [OperationContract]
        List<Product> UserProduct(string login);

        [OperationContract]
        List<Product> WarehoseProductAddedByAdmin();

        [OperationContract]
        void UpdateProductPhoto(string productName, string photo);

        [OperationContract]
        void UserUpdateAvatar(string login, string avatar);

        [OperationContract]
        void ChangePass(string login, string pass);

        [OperationContract]
        void ChangeUserEmail(string login, string newEmail);

        [OperationContract]
        void ChangeUserNickname(string login, string nick);

        [OperationContract]
        DTOUser UserInfo(User user, string login);

        [OperationContract]
        Product ProductInfo(string productName, string userLogin);
    }
}
