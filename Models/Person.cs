using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LUUDUCDAT_MaNguonMo.Models{
    [Table("Persons")]
    public class Person{
        [Key]

        [Display(Name="Mã id")]
        public string PersonID {get; set; }
        [Required]

        [Display(Name="Họ và Tên")]
        public string PersonName {get; set; }
        [MaxLength(30)]

        [Display(Name="Địa Chỉ")]
        public string Address {get; set;}

    }
}