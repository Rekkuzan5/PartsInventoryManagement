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

        private void addPartSavebutton_Click(object sender, EventArgs e)
        {
            //if (addPartMinTextBox > addPartMaxTextBox)
            //{
            //    MessageBox.Show)"The minimum price cannot exceed the maximum price");
            //    return;
            //}

            if (addPartInHouseRadio.Checked)
            {
                InHouse inHouse = new InHouse(int.Parse(addPartIDTextBox.Text), addPartNameTextBox.Text, decimal.Parse(addPriceTextBox.Text),
                int.Parse(addInvTextBox.Text), int.Parse(addPartMaxTextBox.Text), int.Parse(addPartMaxTextBox.Text), int.Parse(IDNameTextBox.Text));
                Inventory.addPart(inHouse);
            }
            else
            {
                Outsourced outsourcedPart = new Outsourced(int.Parse(addPartIDTextBox.Text), addPartNameTextBox.Text, decimal.Parse(addPriceTextBox.Text),
                int.Parse(addInvTextBox.Text), int.Parse(addPartMaxTextBox.Text), int.Parse(addPartMaxTextBox.Text), IDNameTextBox.Text);
                Inventory.addPart(outsourcedPart);
            }
        }

        private void addPartCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
  