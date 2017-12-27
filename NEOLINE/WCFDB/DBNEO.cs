namespace WCFForOnlineShopCenter
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Linq;

    public class OnlineShop : DbContext
    {
        public OnlineShop()
            : base("name=OnlineShop")
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }

    }

    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Login { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Nickname { get; set; }

        [Required]
        public string Email { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        public bool IsAdmin { get; set; }
    }

    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        public string Description { get; set; }

        public string Photo { get; set; }

        [Required]
        public int Amount { get; set; }

        [Required]
        public int Price { get; set; }



        public string UserLogin { get; set; }

        [ForeignKey("UserLogin")]
        public virtual User UsersProducts { get; set; }



        public string CategoryName { get; set; }

        [ForeignKey("CategoryName")]
        public virtual Category Categories { get; set; }


    }

    public class Category
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string CategoryName { get; set; }

        public virtual ICollection<Product> ProductsInCategory { get; set; }

    }

}