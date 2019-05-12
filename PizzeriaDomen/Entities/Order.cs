using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaDomen.Entities
{
    public class Order
    {

        [Key]
        public int ID { get; set; }
        [Required]
        public string OrderComp { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        string OrderStatus { get; set; }
    }
}
