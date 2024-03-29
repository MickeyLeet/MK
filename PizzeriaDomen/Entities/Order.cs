﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaDomen.Entities
{
    public class Order
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public string OrderStatus { get; set; }

        [ForeignKey("UserOf")]
        public int UserId { get; set; }

        public virtual User UserOf { get; set; }
    }
}
