﻿using BLL;
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

        void UpdatePrice(string nameProduct, int price);

        void UpdateAmount(string nameProduct, int amountProduct);

        void UpdateDescription(string nameProduct, string description);

        List<Product> UserProduct(string login);

        List<Product> WarehoseProductAddedByAdmin();
    }
}
