using MY.EDocumentArchive.BusinessLogic;
using MY.EDocumentArchive.BusinessLogic.Model;
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

            cmbType.FillByEnum<PersonType>();
            cmbType.SelectedItem = PersonType.متفرقه;

            if (personId.HasValue)
            {
                var person = ServiceFactory<PersonModel>.FetchByPrimaryKeys(PersonModel.__PrimaryKeys.PersonID(personId.Value));
                cmbType.SelectedValue = person.Type.Value;
                txtFirstName.Text = person.FirstName;
                txtLastName.Text = person.LastName;
                txtName.Text = person.Name;
                txtNationalID.Text = person.NationalID;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var person = new PersonModel();
            if (personId.HasValue)
                person.PersonID = personId.Value;

            person.Type = (PersonType)cmbType.SelectedItem;
            if (cmbType.SelectedItem == PersonType.شخص)
            {
                person.FirstName = txtFirstName.Text;
                person.LastName = txtLastName.Text;
            }
            else
                person.Name = txtName.Text;
            person.NationalID = txtNationalID.Text;

            if (FormValidator.IsValid(this))
            {
                bool success;
                if (personId.HasValue)
                    success = ServiceFactory<PersonModel>.Update(person);
                else
                    success = ServiceFactory<PersonModel>.Insert(ref person);

                if (success)
                    DialogResult = DialogResult.OK;
            }
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cmbType.SelectedItem as EnumItem).Value == PersonType.شخص.Value)
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
            if ((cmbType.SelectedItem as EnumItem).Value == PersonType.شخص.Value)
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
            if ((cmbType.SelectedItem as EnumItem).Value == PersonType.شخص.Value)
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
            if ((cmbType.SelectedItem as EnumItem).Value == PersonType.شخص.Value)
                txtFullName.Text = $"{txtFirstName.Text} {txtLastName.Text}";
            else
                txtFullName.Text = txtName.Text;
        }
    }
}