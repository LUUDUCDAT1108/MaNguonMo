using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LUUDUCDAT_MaNguonMo.Models{
    [Table("Employees")]
    public class Employee{
        [Key]
        [Display(Name="Mã id")]
        public string? EmployeeID {get; set; }
        [Required]

         [Display(Name="Tên")]
        public string? EmployeeName {get; set; }
        [MaxLength(30)]

        [Display(Name="Địa Chỉ")]
        public string? Address {get; set;}

    }
}