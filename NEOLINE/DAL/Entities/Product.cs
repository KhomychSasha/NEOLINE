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
    [DataContract]
    public class Product
    {
        [DataMember]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [DataMember]
        [Required]
        public string ProductName { get; set; }

        [DataMember]
        [Required]
        public string Description { get; set; }

        [DataMember]
        public string Photo { get; set; }

        [DataMember]
        [Required]
        public int Amount { get; set; }

        [DataMember]
        [Required]
        public int Price { get; set; }


        [DataMember]
        public string UserLogin { get; set; }

        [ForeignKey("UserLogin")]
        public virtual User UsersProducts { get; set; }


        [DataMember]
        public string CategoryName { get; set; }

        [ForeignKey("CategoryName")]
        public virtual Category Categories { get; set; }
    }
}
