using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
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
}
