using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DBNeoline;
using DAL;

namespace BLL
{
    public class RealisationBLL : IBLL
    {
        public IDAL dal = new RealisationDB();

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

        public void AddProduct(string productName, string descr, string photo, string login, int AmountOfProduct, int price)
        {
            Product product = new Product()
            {
                ProductName = productName,
                Description = descr,
                Photo = photo,
                UserLogin = login,
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

        public void UpdatePrice(string nameProduct, int price)
        {
            Product user = new Product()
            {
                ProductName = nameProduct
            };

            user.Price = price;
           
        }

        void UpdateAmount(string nameProduct, int amountProduct)
        {

        }

        void UpdateDescription(string nameProduct, string description)
        {

        }

        List<Product> UserProduct(string login)
        {

        }

        List<Product> WarehoseProductAddedByAdmin()
        {

        }


    }
}
