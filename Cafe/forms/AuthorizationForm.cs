using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Cafe
{
    public partial class AuthorizationForm : Form
    {
        UserData userData;

        public AuthorizationForm()
        {
            InitializeComponent();

            userData = new UserData();
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
            userData = (UserData) SerializeUtils.Deserialize(new XmlSerializerType(), typeof(UserData), userData);            
        }

        private void AuthorizationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                SerializeUtils.Serialize(new XmlSerializerType(), typeof(UserData), userData);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void registerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new RegistrationForm(userData).ShowDialog();


        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(loginField.Text) || string.IsNullOrWhiteSpace(passwordField.Text)) return;

            User user = userData.FindUser(loginField.Text);

            if(user == null || !user.Password.Equals(passwordField.Text))
            {
                //User not found or password mismatch
                MessageBox.Show("Данные некорректны");
                return;
            }
        }
    }
}
