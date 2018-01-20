using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IDAL
    {
        void AddUser(User user);

        void AddProduct(Product product);

        bool VerificationOnAdmin(User user);

        bool VerificationOnExistUser(User user);

        bool VerificationLogin(User user);

        bool VerificationNickname(User user);

        bool VerificationEmail(User user);

        void UpdateProductPrice(Product product);

        void UpdateProductAmount(Product product);

        void UpdateProductDescription(Product product);

        List<Product> UserProduct(Product user);

        List<Product> WarehoseProductAddedByAdmin();

        User UserInfo(string login);

        void UpdateProductPhoto(Product prod);

        void UserUpdateAvatar(User user);

        void ChangeUserPass(User user);

        void ChangeUserEmail(User user);

        void ChangeUserNickname(User user);

        Product ProductInfo(string prodName, int userID);
    }
}
