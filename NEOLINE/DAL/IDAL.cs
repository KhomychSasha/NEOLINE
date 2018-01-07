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

        void UpdatePrice(Product product);

        void UpdateAmount(Product product);

        void UpdateDescription(Product product);

        List<Product> UserProduct(Product user);

        List<Product> WarehoseProductAddedByAdmin();
    }
}
