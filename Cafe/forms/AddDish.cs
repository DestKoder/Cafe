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
    public partial class AddDish : Form
    {
        private DishData data;
        public AddDish(DishData data)
        {
            InitializeComponent();
            this.data = data;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddDish_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name.Text))
            {
                MessageBox.Show("Пожалуйста укажите название блюда");
                return;
            }

            data.AddDish(new Dish(name.Text, (double)price.Value, (double)cookTime.Value));
            DialogResult = DialogResult.OK;
        }
    }
}
