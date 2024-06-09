using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Windows.Forms;

namespace MY.CodeGenerator
{
    public partial class GeneratorForm : Form
    {
        private int currentStep;
        private IDictionary<string, StepForm> stepForms;
        private Point mouseDownLocation, initialLocation;
        private bool mouseIsDown = false;
        private string connectionString = null;
        private bool setConnectionString = false;

        public GeneratorForm()
        {
            InitializeComponent();
            stepForms = new Dictionary<string, StepForm>();
            currentStep = 1;
            LoadCurrentStep();
        }

        private void LoadCurrentStep()
        {
            if (!stepForms.ContainsKey($"{currentStep}"))
            {
                var form = (Form)Activator.CreateInstance(Type.GetType($"MY.CodeGenerator.Step{currentStep}Form"));
                stepForms[currentStep.ToString()] = new StepForm(form as IMessageSupport, form.Controls[0]);
            }
            var control = stepForms[currentStep.ToString()].Control;
            if (currentStep == 2)
                stepForms[currentStep.ToString()].Form.Message("SetConnectionString", connectionString, out string _);
            pnlStepsArea.Controls.Clear();
            control.Dock = DockStyle.Fill;
            pnlStepsArea.Controls.Add(control);
            control.BringToFront();
            var menu = pnlMenu.Controls[$"menuStep{currentStep}"] as Label;
            foreach (Control item in pnlMenu.Controls)
                if (item.Name != lblStatus.Name)
                    item.BackColor = Color.Transparent;
            menu.BackColor = Color.FromArgb(31, 43, 55);
            lblTitle.Text = menu.Text;
            btnTestConnection.Visible = currentStep == 1;
        }

        private ModalShadow ShowModalShadow()
        {
            var shadow = new ModalShadow
            {
                Size = Size,
                Location = Location
            };
            shadow.Show();
            return shadow;
        }

        private void ShowDialogBox(string message, bool error = false)
        {
            var shadow = ShowModalShadow();
            new MessageBoxForm(message, error).ShowDialog();
            shadow.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            var result = stepForms["1"].Form.Message("TestConnection", null, out string outputMessage);
            if (!result || !setConnectionString)
                ShowDialogBox(outputMessage, error: !result);
            if (result)
                stepForms["1"].Form.Message("SetConnectionString", null, out connectionString);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnNextStep_Click(object sender, EventArgs e)
        {
            if (currentStep == 1 && string.IsNullOrEmpty(connectionString))
            {
                setConnectionString = true;
                btnTestConnection_Click(btnTestConnection, EventArgs.Empty);
                setConnectionString = false;
            }
            else
            {
                currentStep++;
                if (currentStep > 7)
                    currentStep = 7;
                else
                    LoadCurrentStep();
            }
        }

        private void btnPrevStep_Click(object sender, EventArgs e)
        {
            currentStep--;
            if (currentStep < 1)
                currentStep = 1;
            else
                LoadCurrentStep();
        }

        private void gotoStep(object sender, EventArgs e)
        {
            currentStep = int.Parse((sender as Control).Name.Replace("menuStep", ""));
            LoadCurrentStep();
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseIsDown = true;
                mouseDownLocation = PointToScreen(e.Location);
                initialLocation = Location;
            }
        }

        private void lblTitle_MouseUp(object sender, MouseEventArgs e)
        {
            mouseIsDown = false;
        }

        private void lblTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseIsDown)
            {
                var screenLocation = PointToScreen(e.Location);
                Left = initialLocation.X + screenLocation.X - mouseDownLocation.X;
                Top = initialLocation.Y + screenLocation.Y - mouseDownLocation.Y;
            }
        }
    }
}
