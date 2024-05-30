using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MY.CodeGenerator
{
    public partial class GeneratorForm : Form
    {
        private int currentStep;
        private IDictionary<string, Control> stepForms;

        public GeneratorForm()
        {
            InitializeComponent();
            stepForms = new Dictionary<string, Control>();
            currentStep = 1;
            LoadStep(currentStep);
        }

        private void LoadStep(int step)
        {
            if (!stepForms.ContainsKey(step.ToString()))
            {
                var form = (Form)Activator.CreateInstance(Type.GetType($"MY.CodeGenerator.Step{step}Form"));
                stepForms[step.ToString()] = form.Controls[0];
            }

            var control = stepForms[step.ToString()];
            pnlStepsArea.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panel15.Controls.Add(control);
            control.BringToFront();
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

        private DialogResult ShowDialogBox(string message)
        {
            var shadow = ShowModalShadow();
            var result = MessageBox.Show(message);
            shadow.Close();
            return result;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    var serverAddress = "";
            //    var portNumber = 1433;
            //    if (txtServerAddress.Text.Contains(","))
            //    {
            //        var parts = txtServerAddress.Text.Split(',');
            //        serverAddress = parts[0].Trim();
            //        portNumber = int.Parse(parts[1].Trim());
            //    }
            //    var appConfig = new ApplicationConfig()
            //    {
            //        DatabaseConnection = new SqlServerDatabaseConnection()
            //        {
            //            ServerAddress = serverAddress,
            //            Login = new ServerAuthenticate()
            //            {
            //                Username = txtUserName.Text.Trim(),
            //                Password = txtPassword.Text,
            //            },
            //            DatabaseName = txtDatabaseName.Text.Trim(),
            //            Port = portNumber,
            //        },
            //    };
            //    using (var connection = new SqlConnection(appConfig.DatabaseConnection.ToString()))
            //    {
            //        connection.Open();
            //        using (var command = new SqlCommand("SELECT 1", connection))
            //            command.ExecuteNonQuery();
            //        connection.Close();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    ShowDialogBox(ex.Message);
            //    //throw;
            //}
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnNextStep_Click(object sender, EventArgs e)
        {
            currentStep++;
            if (currentStep > 7)
                currentStep = 7;
            else
                LoadStep(currentStep);
        }

        private void btnPrevStep_Click(object sender, EventArgs e)
        {
            currentStep--;
            if (currentStep < 1)
                currentStep = 1;
            else
                LoadStep(currentStep);
        }
    }
}
