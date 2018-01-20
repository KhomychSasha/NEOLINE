using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace BLL
{
    public interface IBLL
    {
        void AddUser(string login, string pass, string nick, string email);

        void AddProduct(string productName, string descr, BitmapImage photo, int ID, int AmountOfProduct, int price);
        
        bool VerificationOnAdmin(string login, string pass);

        bool VerificationOnExistUser(string login, string pass);

        bool VerificationLogin(string login);

        bool VerificationNickname(string nickname);

        bool VerificationEmail(string email);

        void UpdateProductPrice(string nameProduct, int price);

        void UpdateProductAmount(string nameProduct, int amountProduct);

        void UpdateProductDescription(string nameProduct, string description);

        List<Product> UserProduct(int ID);

        List<Product> WarehoseProductAddedByAdmin();

        void UpdateProductPhoto(string productName,BitmapImage photo);

        void UserUpdateAvatar(string login,BitmapImage avatar);

        void ChangeUserPass(string login,string pass);

        void ChangeUserEmail(string login, string pass);

        void ChangeUserNickname(string login,string nick);

        DTOProduct ProdInfo(string productName,int ID);

        DTOUser UsInfo(string login);
    }
}
