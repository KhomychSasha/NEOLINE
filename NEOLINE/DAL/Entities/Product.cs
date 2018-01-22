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
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        public string Description { get; set; }

        public byte[] Photo { get; set; }

        [Required]
        public int Amount { get; set; }

        [Required]
        public int Price { get; set; }


        public int UserID { get; set; }

        [ForeignKey("UserID")]
        public virtual User UserIDs { get; set; }


        public int CategoryID { get; set; }

        [ForeignKey("CategoryID")]
        public virtual Category Categories { get; set; }
    }
}
