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
    public partial class ModifyPart : Form
    {
        //Form1 mainForm = (Form1)Application.OpenForms["Form1"];

        public ModifyPart()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        //public ModifyPart(int loadPart)
        //{
        //Like this better

        //InitializeComponent();
        //modPartIDTextBox.Text = loadPart.ToString();
        //modPartID = loadPart;

        //modNameTextBox.Text = Inventory.LookupPart(modPartID).Name;
        //modInventoryTextBox.Text = Inventory.LookupPart(modPartID).InStock.ToString();
        //modPriceTextBox.Text = Inventory.LookupPart(modPartID).Price.ToString();
        //modMaxTextBox.Text = Inventory.LookupPart(modPartID).Max.ToString();
        //modMinTextBox.Text = Inventory.LookupPart(modPartID).Min.ToString();


        public ModifyPart(InHouse housePart)
            {
                InitializeComponent();

                modPartIDTextBox.Text = housePart.PartID.ToString();
                modNameTextBox.Text = housePart.Name.ToString();
                modInventoryTextBox.Text = housePart.InStock.ToString();
                modPriceTextBox.Text = housePart.Price.ToString();
                modMaxTextBox.Text = housePart.Max.ToString();
                modMinTextBox.Text = housePart.Min.ToString();
                modMachineIDTextBox.Text = housePart.MachineID.ToString();
                partMachineIDLabel.Text = "Machine ID";
                InHouseRadButton.Checked = true;
            }

            public ModifyPart(Outsourced outsidePart)
            {
                InitializeComponent();

                modPartIDTextBox.Text = outsidePart.PartID.ToString();
                modNameTextBox.Text = outsidePart.Name.ToString();
                modInventoryTextBox.Text = outsidePart.InStock.ToString();
                modPriceTextBox.Text = outsidePart.Price.ToString();
                modMaxTextBox.Text = outsidePart.Max.ToString();
                modMinTextBox.Text = outsidePart.Min.ToString();
                modMachineIDTextBox.Text = outsidePart.CompanyName.ToString();
                partMachineIDLabel.Text = "Company Name";
                OutsourcedRadButton.Checked = true;
            }

        private void modifyPartCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OutsourcedRadButton_CheckedChanged(object sender, EventArgs e)
        {
            if (OutsourcedRadButton.Checked)
            {
                partMachineIDLabel.Text = "Company Name";
            }
            else
            {
                partMachineIDLabel.Text = "Machine ID";
            }
        }

        private void Partsavebutton_click(object sender, EventArgs e)
        {
            if (InHouseRadButton.Checked)
            {
                InHouse inHousePart = new InHouse(int.Parse(modPartIDTextBox.Text), modNameTextBox.Text, decimal.Parse(modPriceTextBox.Text),
                int.Parse(modInventoryTextBox.Text), int.Parse(modMaxTextBox.Text), int.Parse(modMinTextBox.Text), int.Parse(modMachineIDTextBox.Text));
                Inventory.UpdatePart(int.Parse(modPartIDTextBox.Text), inHousePart);
                InHouseRadButton.Checked = true;
            }
            else if (OutsourcedRadButton.Checked)
            {
                Outsourced outsourcedPart = new Outsourced(int.Parse(modPartIDTextBox.Text), modNameTextBox.Text, decimal.Parse(modPriceTextBox.Text),
                int.Parse(modInventoryTextBox.Text), int.Parse(modMaxTextBox.Text), int.Parse(modMinTextBox.Text), modMachineIDTextBox.Text);
                Inventory.UpdatePart(int.Parse(modPartIDTextBox.Text), outsourcedPart);
                OutsourcedRadButton.Checked = true;
            }

            Close();
            //mainForm.Form1Load();
            Form1 mainForm = (Form1)Application.OpenForms["Form1"];
            mainForm.Refresh();
            
        }
    }
}
