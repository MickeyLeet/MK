using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Required, StringLength(200)]
        public string Email { get; set; }

    }
}
