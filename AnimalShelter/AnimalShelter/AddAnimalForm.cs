using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalShelter
{
    public partial class AddAnimalForm : Form
    {
        public AddAnimalForm()
        {
            InitializeComponent();
            cbAnimalType.Items.Add("Cat");
            cbAnimalType.Items.Add("Dog");
        }

        DateTime birthdate = DateTime.Today;

        public string AnimalName { get; set; }
        public string AnimalType { get; set; }

        public DateTime AnimalBirthdate
        {
            get { return birthdate; }
        }

        private void cbAnimalType_SelectedIndexChanged(object sender, EventArgs e)
        {
            AnimalType = cbAnimalType.Text;

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            AnimalName = tbName.Text;
        }

        private void birthdatePicker_ValueChanged(object sender, EventArgs e)
        {
            birthdate = birthdatePicker.Value;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (AnimalName == "" || AnimalType == "")
            {
                MessageBox.Show("Some field are blank!");
                return;
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
