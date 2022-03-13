using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LUUDUCDAT_MaNguonMo.Models{
    [Table("Students")]
    public class Student{
        [Key]
        [Display(Name="Sinh Viên ID")]
        public string? StudentID {get; set; }
        [Required]

        [Display(Name="Họ và Tên Sinh Viên")]
        public string? StudentName {get; set; }
        [MaxLength(30)]

        [Display(Name="Địa Chỉ")]
        public string? Address {get; set;}
    }
}