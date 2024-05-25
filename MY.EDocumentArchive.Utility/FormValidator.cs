using System.Windows.Forms;

namespace MY
{
    static public class FormValidator
    {
        static public bool IsValid(Form form)
        {
            var valid = true;
            foreach (Control control in form.Controls)
            {
                if (control is IValidationControl)
                    valid &= (control as IValidationControl).IsValid();
            }
            return valid;
        }

        static public class Messages
        {
            static public string فیلد_اجباری_وارد_نشده_است = "مقدار فیلد وارد نشده است";
            static public string تاریخ_شمسی_اشتباه_است = "تاریخ شمسی اشتباه است";
        }
    }
}
