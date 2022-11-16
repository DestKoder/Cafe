using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe.forms
{
    public partial class AdministratorForm : Form
    {
        DishData data;
        public AdministratorForm(User user)
        {
            InitializeComponent();
            data = new DishData();
            this.Text = user.FirstName + " " + user.LastName + " " + user.Role;
        }

        private void menuAddButton_Click(object sender, EventArgs e)
        {
            if(new AddDish(data).ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                foreach (Dish item in data.Dishes)
                {
                    listBox1.Items.Add(item);
                }
            }
        }

        private void menuDelButton_Click(object sender, EventArgs e)
        {

        }

        private void AdministratorForm_Load(object sender, EventArgs e)
        {
            this.data = (DishData)SerializeUtils.Deserialize(new XmlSerializerType(),typeof(DishData), data);

            foreach(Dish item in data.Dishes)
            {
                listBox1.Items.Add(item);
            }
        }

        private void AdministratorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                SerializeUtils.Serialize(new XmlSerializerType(), typeof(DishData), data);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
