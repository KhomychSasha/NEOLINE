using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

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

        public byte[] Photo { get; set; }

        [DataMember]
        [Required]
        public int Amount { get; set; }

        [DataMember]
        [Required]
        public int Price { get; set; }

        [DataMember]
        public int UserID { get; set; }

        [ForeignKey("UserID")]
        public virtual User UserIDs { get; set; }

        [DataMember]
        public int CategoryID { get; set; }

        [ForeignKey("CategoryID")]
        public virtual Category Categories { get; set; }
    }
}
