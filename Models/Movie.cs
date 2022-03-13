using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LUUDUCDAT_MaNguonMo.Models
{
    [Table("Movies")]
    public class Movie
    {
        [Key]
        [Display(Name="Mã id")]
        public int Id { get; set; }
        [MinLength(3)]
        [MaxLength(30)]
        [Required (ErrorMessage = "warring!")]

        [Display(Name="Tiêu đề")]
        public string? Title { get; set; }

        [Display(Name="Ngày phát hành")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Display(Name="Thể loại")]
        public string? Genre { get; set; }

        [Display(Name="Giá bán")]
        public decimal Price { get; set; }
    }
}