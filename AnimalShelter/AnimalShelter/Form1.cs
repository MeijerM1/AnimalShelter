using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace AnimalShelter
{
    public partial class Form1 : Form
    {
        Administration administration = new Administration();

        public Form1()
        {
            InitializeComponent();
        }

        private void btEditAnimalInfo_Click(object sender, EventArgs e)
        {
            if (lbAnimalOverview.SelectedIndex > -2)
            {
                ChangeTextBoxStates(false);
                UpdateComboBox();
            }
        }

        private void btSaveAnimalInfo_Click(object sender, EventArgs e)
        {
            ChangeTextBoxStates(true);
            var catItem = administration.Cats.FirstOrDefault(o => o.Name == lbAnimalOverview.SelectedItem.ToString());        

            if (catItem != null)
            {
                updateCatInformation(catItem);
            }
            else if (catItem == null)
            {
                var dogItem = administration.Dogs.FirstOrDefault(o => o.Name == lbAnimalOverview.SelectedItem.ToString());
                if(dogItem != null)
                    updateDogInformation(dogItem);
            }
            ChangeTextBoxStates(true);
            updateListBox();

        }

        private void btAddAnimal_Click(object sender, EventArgs e)
        {
            AddAnimalForm AnimalForm = new AddAnimalForm();

            if (AnimalForm.ShowDialog() == DialogResult.OK)
            {
                if (AnimalForm.AnimalType == "Cat")
                {
                    Cat cat = new Cat(AnimalForm.AnimalName, AnimalForm.AnimalBirthdate);
                    administration.AddCat(cat);
                }
                else if (AnimalForm.AnimalType == "Dog")
                {
                    Dog dog = new Dog(AnimalForm.AnimalName, AnimalForm.AnimalBirthdate);
                    administration.AddDog(dog);
                }
            }

            updateListBox();
        }

        private void btnAddOwner_Click(object sender, EventArgs e)
        {
            AddUserForm userForm = new AddUserForm();
            if (userForm.ShowDialog() == DialogResult.OK)
            {
                Owner owner = new Owner(userForm.OwnerName, userForm.AnimalBirthdate, userForm.OwnerAdress);
                administration.AddOwner(owner);
            }
        }

        private void lbAnimalOverview_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var item = administration.Cats.FirstOrDefault(o => o.Name == lbAnimalOverview.SelectedItem.ToString());
                if (item != null)
                {
                    getCatInformation(item);
                }
                else
                {
                    var dog = administration.Dogs.FirstOrDefault(o => o.Name == lbAnimalOverview.SelectedItem.ToString());
                    if (dog != null)
                        GetDogInformation(dog);
                    else
                    {
                        return;
                    }
                }

            }
            catch (NullReferenceException)
            {                                
            }
        }

        private void getCatInformation(Cat cat)
        {
            ClearTextBoxes();

            tbInfoName.Text = cat.Name;
            dtpInfoDate.Value = cat.Birthdate;

            if (cat.Owner != null)
                cbInfoOwner.Text = cat.Owner.Name;

            if(cat.Habits != null)
                foreach (var i in cat.Habits)
                {
                    tbInfoHabit.Text = i;
                }

            tbInfoPrice.Text = Convert.ToString(cat.Price);

            if (cat.IsReserved)
            {
                rbInfoReservedYes.Checked = true;
                rbInfoReservedNo.Checked = false;
            }
            else
            {
                rbInfoReservedNo.Checked = true;
                rbInfoReservedYes.Checked = false;
            }
        }

        private void GetDogInformation(Dog dog)
        {
            ClearTextBoxes();

            tbInfoName.Text = dog.Name;
            dtpInfoDate.Value = dog.Birthdate;

            if (dog.Owner != null)
                cbInfoOwner.Text = dog.Owner.Name;

            dtpInfoWalkDate.Value = dog.TimeOfLastWalk;


            tbInfoPrice.Text = Convert.ToString(dog.Price);

            if (dog.IsReserved)
            {
                rbInfoReservedYes.Checked = true;
                rbInfoReservedNo.Checked = false;
            }
            else
            {
                rbInfoReservedNo.Checked = true;
                rbInfoReservedYes.Checked = false;
            }
        }

        private void ChangeTextBoxStates(Boolean status)
        {
            tbInfoHabit.ReadOnly = status;
            tbInfoName.ReadOnly = status;
            tbInfoPrice.ReadOnly = status;

            if (status == true)
            {
                dtpInfoDate.Enabled = false;
                cbInfoOwner.Enabled = false;
                rbInfoReservedYes.Enabled = false;
                rbInfoReservedNo.Enabled = false;
                dtpInfoWalkDate.Enabled = false;
            }
            else
            {
                dtpInfoDate.Enabled = true;
                cbInfoOwner.Enabled = true;
                dtpInfoWalkDate.Enabled = true;
                rbInfoReservedYes.Enabled = true;
                rbInfoReservedNo.Enabled = true;
            }
        }
        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void updateListBox()
        {
            lbAnimalOverview.Items.Clear();

            foreach (var i in administration.Cats)
            {
                lbAnimalOverview.Items.Add(i.Name);
            }

            foreach (var i in administration.Dogs)
            {
                lbAnimalOverview.Items.Add(i.Name);
            }
        }

        private void UpdateComboBox()
        {
            foreach (var i in administration.Owners)
                cbInfoOwner.Items.Add(i.Name);
        }

        private void updateCatInformation(Cat cat)
        {
            cat.Name = tbInfoName.Text;
            cat.Birthdate = dtpInfoDate.Value;
            cat.Habits.Add(tbInfoHabit.Text);
            if (cbInfoOwner.SelectedIndex > -1)
            {
                var owner = administration.Owners.FirstOrDefault(o => o.Name == lbAnimalOverview.SelectedItem.ToString());
                cat.Owner = owner;
            }

            if (rbInfoReservedYes.Checked)
                cat.IsReserved = true;
            else
                cat.IsReserved = false;

            cat.Price = Convert.ToDecimal(tbInfoPrice.Text);
        }
        private void updateDogInformation(Dog dog)
        {
            dog.Name = tbInfoName.Text;
            dog.Birthdate = dtpInfoDate.Value;
            if (cbInfoOwner.SelectedIndex > -1)
            {
                var owner = administration.Owners.FirstOrDefault(o => o.Name == lbAnimalOverview.SelectedItem.ToString());
                dog.Owner = owner;
            }

            if (rbInfoReservedYes.Checked)
                dog.IsReserved = true;
            else
                dog.IsReserved = false;

            dog.Price = Convert.ToDecimal(tbInfoPrice.Text);
            dog.ChangeDateOfLastWalk(dtpInfoWalkDate.Value);
        }
    }
}
