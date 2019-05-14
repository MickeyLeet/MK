using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaDomen.Entities
{
    [Table("tbl_UserOrders")]
    public class UserOrder
    {
        [Key]
        public int Id { get; set; }
        [Required,ForeignKey("OrderOf")]
        public int OrderId { get; set; }
        [Required, ForeignKey("ProductOf")]
        public int ProductId { get; set; }

        public virtual Order OrderOf { get; set; }

        public virtual Product ProductOf { get; set; }

    }
}
