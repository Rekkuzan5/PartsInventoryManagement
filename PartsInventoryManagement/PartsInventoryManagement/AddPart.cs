using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartsInventoryManagement
{
    public partial class AddPart : Form
    {
        public AddPart()
        {
            InitializeComponent();
            if (addPartNameTextBox.Text != "")
            {
                //addPartNameTextBox.BackColor = Color.White; ;
            }

        }



        private void AddPart_Load(object sender, EventArgs e)
        {

        }

        // Save button calls verify method
        private void AddPartSavebutton_Click(object sender, EventArgs e)
        {
            VerifyPartSave();

        }

        // verifies if entered information is correct and creates either inhouse or outsourced part
        private void VerifyPartSave()
        {
            if (int.Parse(addPartMinTextBox.Text) > int.Parse(addPartMaxTextBox.Text))
            {
                MessageBox.Show("The minimum amount cannot exceed the maximum");
                return;
            }

            if (addPartInHouseRadio.Checked)
            {
                int partID = Inventory.AllParts[Inventory.AllParts.Count - 1].PartID + 1;
                InHouse inHouse = new InHouse(partID, addPartNameTextBox.Text, decimal.Parse(addPriceTextBox.Text),
                int.Parse(addInvTextBox.Text), int.Parse(addPartMaxTextBox.Text), int.Parse(addPartMaxTextBox.Text), int.Parse(IDNameTextBox.Text));
                Inventory.AddPart(inHouse);
            }
            else
            {
                int partID = (Inventory.AllParts[Inventory.AllParts.Count - 1].PartID + 1);
                Outsourced outsourcedPart = new Outsourced(partID, addPartNameTextBox.Text, decimal.Parse(addPriceTextBox.Text),
                int.Parse(addInvTextBox.Text), int.Parse(addPartMaxTextBox.Text), int.Parse(addPartMaxTextBox.Text), IDNameTextBox.Text);
                Inventory.AddPart(outsourcedPart);
            }
            this.Close();
        }
      
        private void AddPartOutsourceRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (addPartOutsourceRadio.Checked)
            {
                addPartIDorNameLabel.Text = "Company Name";
            }
            else
            {
                addPartIDorNameLabel.Text = "Machine ID";
            }
        }

         private void AddPartCancelButton_Click(object sender, EventArgs e)
         {
            this.Close();
         }

        private void addPartNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            addPartNameTextBox.BackColor = Color.White;
        }

        private void addInvTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            addInvTextBox.BackColor = Color.White;
        }

        private void addPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            addPriceTextBox.BackColor = Color.White;
        }

        private void addPartMaxTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            addPartMaxTextBox.BackColor = Color.White;
        }

        private void addPartMinTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            addPartMinTextBox.BackColor = Color.White;
        }

        private void IDNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            IDNameTextBox.BackColor = Color.White;
        }
    }
}
  