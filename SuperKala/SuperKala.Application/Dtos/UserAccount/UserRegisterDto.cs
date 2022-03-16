using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using SuperKala.BaseStatic.ErrorAndMessage;

namespace SuperKala.Application.Dtos.UserAccount
{
    public class UserRegisterDto
    {
        [Required(ErrorMessage=ErrorAndMessage.Required)]
        [MaxLength(50,ErrorMessage = ErrorAndMessage.MaxFileSize)]
        public string UserName { get; set; }

        [Required(ErrorMessage = ErrorAndMessage.Required)]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = ErrorAndMessage.Required)]
        [Phone(ErrorMessage = ErrorAndMessage.Phone)]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = ErrorAndMessage.Required)]
        [MaxLength(50, ErrorMessage = ErrorAndMessage.MaxFileSize)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = ErrorAndMessage.Required)]
        [Compare("Password", ErrorMessage = ErrorAndMessage.PasswordNotMatch)]
        [DataType(DataType.Password)]
        [MaxLength(50, ErrorMessage = ErrorAndMessage.MaxFileSize)]
        public string RePassword { get; set; }
    }
}
