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
    public class User
    {
        [DataMember]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [DataMember]
        [Required]
        public string Login { get; set; }

        [DataMember]
        [Required]
        public string Password { get; set; }

        [DataMember]
        [Required]
        public string Nickname { get; set; }

        [DataMember]
        [Required]
        public string Email { get; set; }

        [DataMember]
        public virtual ICollection<Product> Products { get; set; }

        [DataMember]
        public bool IsAdmin { get; set; }

        public byte[] Avatar { get; set; }
    }
}
