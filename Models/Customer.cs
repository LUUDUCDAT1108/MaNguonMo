using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LUUDUCDAT_MaNguonMo.Models{
    [Table("Customers")]
    public class Customer:Person {

        [Display(Name="Email")]
        public string? Email {get; set;}
        [MaxLength(30)]

        [Display(Name="Giới tính")]
        public string? Gender {get; set; }

        [Display(Name="Sinh nhật")]
        [DataType(DataType.Date)]
        public DateTime Birthday {get; set; }
    }
}