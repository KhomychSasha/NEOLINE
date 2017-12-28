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

        void UpdatePrice(string nameProduct, int price);

        void UpdateAmount(string nameProduct, int amountProduct);

        void UpdateDescription(string nameProduct, string description);

        List<Product> UserProduct(string login);

        List<Product> WarehoseProductAddedByAdmin();
    }
}
