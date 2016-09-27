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
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        DateTime birthdate = DateTime.Today;
        public string OwnerName { get; set; }
        public string OwnerAdress { get; set; }
        public DateTime AnimalBirthdate
        {
            get { return birthdate; }
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            OwnerName = tbName.Text;
        }

        private void tbAdress_TextChanged(object sender, EventArgs e)
        {
            OwnerAdress = tbAdress.Text;
        }

        private void birthdatePicker_ValueChanged(object sender, EventArgs e)
        {
            birthdate = birthdatePicker.Value;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (OwnerName == "" || OwnerAdress == "")
            {
                MessageBox.Show("Some field are blank!");
                return;
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
