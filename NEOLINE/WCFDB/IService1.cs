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
        void AddProduct(string productName, string Descr, string Photo);

        [OperationContract]
        void AddAdmin(string login, string pass, string email);
    }
}
