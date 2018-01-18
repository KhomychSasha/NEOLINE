namespace DBNeoline
{
    using DAL;
    using DAL.Entities;
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
            //Database.SetInitializer<OnlineShop>(new MyInitializer<OnlineShop>());
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
    }
}