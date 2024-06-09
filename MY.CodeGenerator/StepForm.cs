using System.Windows.Forms;

namespace MY.CodeGenerator
{
    sealed public class StepForm
    {
        public StepForm(IMessageSupport form, Control control)
        {
            Form = form;
            Control = control;
        }

        public IMessageSupport Form { get; }
        public Control Control { get; }
    }
}
