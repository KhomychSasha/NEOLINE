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
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        void AddUser(string login, string pass, string nick, string email);

        [OperationContract]
        void AddProduct(string productName, string descr, BitmapImage photo, int userID, int AmountOfProduct, int price);

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
        List<Product> UserProduct(int ID);

        [OperationContract]
        List<Product> WarehoseProductAddedByAdmin();

        [OperationContract]
        void UpdateProductPhoto(string productName, BitmapImage photo);

        [OperationContract]
        void UserUpdateAvatar(string login, BitmapImage avatar);

        [OperationContract]
        void ChangePass(string login, string pass);

        [OperationContract]
        void ChangeUserEmail(string login, string newEmail);

        [OperationContract]
        void ChangeUserNickname(string login, string nick);

        [OperationContract]
        DTOUser UserInfo(string login);

        [OperationContract]
        DTOProduct ProdInfo(string productName, int userID);
    }
}
