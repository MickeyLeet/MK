using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaDomen.Entities
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        [Required, StringLength(40)]
        public string Login { get; set; }
        [Required, StringLength(500)]
        public string Password { get; set; }

        [Required, StringLength(500)]
        public string Name { get; set; }

        [Required, StringLength(200)]
        public string Email { get; set; }

        //[Required, ForeignKey("Order")]
        //public int OrderID { get; set; }

        //[Required, ForeignKey("Role")]
        //public int RoleID { get; set; }


    }
}
