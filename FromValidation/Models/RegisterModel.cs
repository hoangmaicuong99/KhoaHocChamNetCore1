using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace FromValidation.Models
{
    public class RegisterModel
    {
        [EmailAddress(ErrorMessage = "Vui lòng nhập đúng định dạng email!")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email không được trống!")]
        public string email { get; set; }

        [Required(AllowEmptyStrings = false , ErrorMessage = " Mật khẩu không được trống!")]
        [StringLength(maximumLength:50, MinimumLength =8,ErrorMessage = "Mật khẩu từ 8 đến 50 ký tự!")]
        public string pass { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Mật khẩu nhập lại không được trống!")]
        [Compare(otherProperty: "pass", ErrorMessage = "Mật khẩu nhập lại không đúng!")]
        public string retypePass { get; set; }
    }
}
