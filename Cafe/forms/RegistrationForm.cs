using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe
{
    public partial class RegistrationForm : Form
    {
        private UserData userData;
        public RegistrationForm(UserData userData)
        {
            InitializeComponent();

            this.userData = userData;
            comboBox1.SelectedIndex = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void regButton_Click(object sender, EventArgs e){
            if (string.IsNullOrWhiteSpace(loginField.Text) || string.IsNullOrWhiteSpace(passwordField.Text) || string.IsNullOrWhiteSpace(emailField.Text) || string.IsNullOrWhiteSpace(firstNameField.Text) || string.IsNullOrWhiteSpace(lastNameField.Text)){
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            userData.AllUsers.Add(new User(loginField.Text, passwordField.Text, firstNameField.Text, lastNameField.Text, emailField.Text, (UserRole)comboBox1.SelectedIndex));
            this.DialogResult = DialogResult.OK;        
        }
    }
}
