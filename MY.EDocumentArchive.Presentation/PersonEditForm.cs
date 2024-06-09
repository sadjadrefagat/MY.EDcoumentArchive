using DevExpress.XtraEditors;
using MY.EDocumentArchive.BusinessLogic;
using MY.EDocumentArchive.BusinessLogic.Model;
using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace MY.EDocumentArchive.Presentation
{
    public partial class PersonEditForm : Form
    {
        private long? personId;
        private PersianCalendar persia = new PersianCalendar();

        public PersonEditForm(long? personId = null)
        {
            InitializeComponent();

            var persianCulture = new CultureInfo("fa-IR");




            calendarControl1.DateFormat = persianCulture.DateTimeFormat;




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

                propertyGridControl1.SelectedObject = person;
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

        private void dropDownButton1_Click(object sender, EventArgs e)
        {
            //cameraControl1.Capture = true;
        }

        private void DrawPersianDay()
        {
        }

        private void calendarControl1_CustomDrawDayNumberCell(object sender, DevExpress.XtraEditors.Calendar.CustomDrawDayNumberCellEventArgs e)
        {
            e.Handled = true;


            Pen p = e.Cache.GetPen(Color.Violet);
            e.Cache.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
            e.Cache.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            e.Cache.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            var persianDayNumber = persia.GetDayOfMonth(e.Date);
            var format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            if (e.Selected)
                e.Cache.FillRectangle(Brushes.Blue, e.Bounds);

            if (e.State == DevExpress.Utils.Drawing.ObjectState.Hot)
                e.Cache.DrawRectangle(new Pen(Color.Gray), e.Bounds);
            e.Cache.DrawString($"{persianDayNumber}", Font, Brushes.Gray, e.Bounds, format);

            //var persianDayNumber = e.Date.Day;
            //MessageBox.Show($"{persianDayNumber}");
        }
    }
}