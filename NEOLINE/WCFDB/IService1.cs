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
        void RegistrationUser(string login, string pass, string nick, string email);

        [OperationContract]
        void AddProduct(string productName, string descr, string photo, string login,int AmountOfProduct,int price);

        [OperationContract]
        bool VerificationOnAdmin(string login,string pass);

        [OperationContract]
        bool VerificationOnExistUser(string login, string pass);

        [OperationContract]
        bool VerificationLogin(string login);

        [OperationContract]
        bool VerificationNickname(string nickname);

        [OperationContract]
        bool VerificationEmail(string email);

        [OperationContract]
        void UpdatePrice(string nameProduct,int price);

        [OperationContract]
        void UpdateAmount(string nameProduct,int amountProduct);

        [OperationContract]
        void UpdateDescription(string nameProduct,string description);

        [OperationContract]
        List<Product> UserProduct(string login);

        [OperationContract]
        List<Product> WarehoseProductAddedByAdmin();
    }
}
