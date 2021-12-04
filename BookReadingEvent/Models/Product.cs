using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookReadingEvent.Models
{
    [Table("tblProducts")]
    public class Product
    {
        [Key]
        [Required(ErrorMessage ="Event Id is Required")]//Validations
        public int ProductId { get; set; }

        [StringLength(1,MinimumLength=7,ErrorMessage ="")]//Validations
        public string Name { get; set; }
        public Nullable<decimal> Price { get; set; }
    }
}