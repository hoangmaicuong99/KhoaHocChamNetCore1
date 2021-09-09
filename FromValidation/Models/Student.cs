using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FromValidation.Models
{
    public class Student
    {
        [Display(Name = "ID: ")]
        public int id { get; set; }
        [Display(Name = "Tên: ")]
        [Required(ErrorMessage = "Vui lòng nhập dữ liệu!")]
        [StringLength(maximumLength:25,MinimumLength = 3, ErrorMessage = "nhập từ 5 tới 25!")]
        public string name { get; set; }
        [Display(Name = "Description: ")]
        public string description { get; set; }
        [EmailAddress(ErrorMessage = "Vui lòng nhập đúng định dạng Email!")]
        public string? email { get; set; }
    }
}
