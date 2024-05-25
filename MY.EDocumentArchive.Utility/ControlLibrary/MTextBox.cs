using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace MY.ControlLibrary
{
    [DefaultEvent("CustomValidation")]
    public partial class MTextBox : TextBox, IValidationControl
    {
        public event CustomValidationEventHandler CustomValidation;

        public MTextBox()
        {
            InitializeComponent();
        }

        [DefaultValue(false)]
        public bool IsRequired { get; set; } = false;

        public bool IsValid()
        {
            var valid = true;
            var errorMessage = "";
            errorProvider1.Clear();
            BackColor = Color.White;
            if (IsRequired)
            {
                if (string.IsNullOrWhiteSpace(Text))
                {
                    errorMessage = FormValidator.Messages.فیلد_اجباری_وارد_نشده_است;
                    valid = false;
                }
            }
            if (valid && CustomValidation != null)
            {
                errorMessage = CustomValidation();
                if (!string.IsNullOrEmpty(errorMessage))
                    valid = false;
            }

            if (!valid)
            {
                errorProvider1.SetError(this, errorMessage);
                Focus();
                BackColor = Color.Yellow;
            }
            return valid;
        }
    }
}
