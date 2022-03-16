using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperKala.BaseStatic.ErrorAndMessage
{
    public static class ErrorAndMessage
    {

        #region CrudError
        public const string DuplicatedRecord = "امکان ثبت رکورد تکراری وجود ندارد";
        public const string RecordNotFound = "رکورد با اطلاعات درخواست شده یافت نشد";
        public const string Required = "لطفا فیلد را پر کنید";
        public const string MaxFileSize = "حجم فایل زیاد است";
        public const string MaxCharacter = "کاراکتر زیاد است";
        public const string FileFormatInvalid = "فرمت فایل اشتباه هست";
        #endregion

        #region AcoountError
        public const string Phone = "فرمت شماره صحیح نیست ";
        public const string PasswordNotMatch = "پسورد و تکرار پسورد صحیح نیست";
        #endregion
    }
}
