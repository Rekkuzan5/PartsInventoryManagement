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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
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
                InHouse inHouse = new InHouse(Inventory.AllParts.Count + 1, addPartNameTextBox.Text, decimal.Parse(addPriceTextBox.Text),
                int.Parse(addInvTextBox.Text), int.Parse(addPartMaxTextBox.Text), int.Parse(addPartMaxTextBox.Text), int.Parse(IDNameTextBox.Text));
                Inventory.addPart(inHouse);
            }
            else
            {
                Outsourced outsourcedPart = new Outsourced(Inventory.AllParts.Count + 1, addPartNameTextBox.Text, decimal.Parse(addPriceTextBox.Text),
                int.Parse(addInvTextBox.Text), int.Parse(addPartMaxTextBox.Text), int.Parse(addPartMaxTextBox.Text), IDNameTextBox.Text);
                Inventory.addPart(outsourcedPart);
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

    }
}
  