using System.Windows.Forms;

namespace MY.CodeGenerator
{
    public partial class MessageBoxForm : Form
    {
        public MessageBoxForm(string messaage, bool error)
        {
            InitializeComponent();
            lblMessage.Text = messaage;
            lblIcon.Text = error ? "r" : "i";
        }

        private void btnFinish_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void MessageBoxForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape || e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                Close();
            }
        }
    }
}
