using MY.EDocumentArchive.Model;
using System;
using System.Windows.Forms;

namespace MY.EDocumentArchive.Presentation
{
    public partial class PersonEditForm : Form
    {
        private long? personId;

        public PersonEditForm(long? personId = null)
        {
            InitializeComponent();
            this.personId = personId;
            cmbType.SelectedIndex = 0;

            if (personId.HasValue)
            {
                var person = ServiceFactory<Person>.FetchByPrimaryKey(personId.Value);
                cmbType.SelectedIndex = person.Type;
                txtFirstName.Text = person.FirstName;
                txtLastName.Text = person.LastName;
                txtName.Text = person.Name;
                txtNationalID.Text = person.NationalID;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var person = new Person();
            if (personId.HasValue)
                person.PersonID = personId.Value;

            person.Type = cmbType.SelectedIndex;
            if (cmbType.SelectedIndex == 0)
            {
                person.FirstName = txtFirstName.Text;
                person.LastName = txtLastName.Text;
            }
            else
                person.Name = txtName.Text;
            person.NationalID = txtNationalID.Text;

            if (FormValidator.IsValid(this) && ServiceFactory<Person>.Save(ref person))
                DialogResult = DialogResult.OK;
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbType.SelectedIndex == 0)
                txtName.Clear();
            else
            {
                txtFirstName.Clear();
                txtLastName.Clear();
            }
            txtFirstName.IsRequired = cmbType.SelectedIndex == 0;
            txtFirstName.Enabled = cmbType.SelectedIndex == 0;
            txtLastName.IsRequired = cmbType.SelectedIndex == 0;
            txtLastName.Enabled = cmbType.SelectedIndex == 0;
            txtName.IsRequired = cmbType.SelectedIndex == 1;
            txtName.Enabled = cmbType.SelectedIndex == 1;
        }

        private string txtFirstName_CustomValidation()
        {
            if (cmbType.SelectedIndex == 0)
            {
                if (string.IsNullOrEmpty(txtFirstName.Text))
                    return FormValidator.Messages.فیلد_اجباری_وارد_نشده_است;
            }
            return string.Empty;
        }

        private string txtNationalID_CustomValidation()
        {
            foreach (var ch in txtNationalID.Text)
                if (!char.IsNumber(ch))
                    return "کد ملی نامعتبر است";
            if (cmbType.SelectedIndex == 0)
            {
                if (txtNationalID.Text.Length != 10)
                    return "طول کد ملی نامعتبر است";
            }
            else if (txtNationalID.Text.Length != 11)
                return "طول کد ملی نامعتبر است";
            return string.Empty;
        }

        private void CreateFullName(object sender, EventArgs e)
        {
            if (cmbType.SelectedIndex == 0)
                txtFullName.Text = $"{txtFirstName.Text} {txtLastName.Text}";
            else
                txtFullName.Text = txtName.Text;
        }
    }
}