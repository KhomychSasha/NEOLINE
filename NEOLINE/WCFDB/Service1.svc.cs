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
        public RealisationBLL bll = new RealisationBLL();

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

        public void UpdatePrice(string nameProduct, int price)
        {
            bll.UpdatePrice(nameProduct,price);
        }

        public void UpdateAmount(string nameProduct, int amountProduct)
        {
            bll.UpdateAmount(nameProduct,amountProduct);
        }

        public void UpdateDescription(string nameProduct, string description)
        {
            bll.UpdateDescription(nameProduct,description);
        }

        public List<Product> UserProduct(string login)
        {
            return bll.UserProduct(login);
        }

        public List<Product> WarehoseProductAddedByAdmin()
        {
            return bll.WarehoseProductAddedByAdmin();
        }
    }
}
