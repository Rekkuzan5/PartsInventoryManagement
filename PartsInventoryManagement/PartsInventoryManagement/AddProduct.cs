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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
            AddProductLoadScreen();
        }

        private void CancelProductButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddProductLoadScreen()
        {
            var showAllParts = new BindingSource();
            showAllParts.DataSource = Inventory.AllParts;
            AllPartsDataGrid.DataSource = showAllParts;

            AllPartsDataGrid.Columns["PartID"].HeaderText = "Part ID";
            AllPartsDataGrid.Columns["Name"].HeaderText = "Part Name";
            AllPartsDataGrid.Columns["InStock"].HeaderText = "Inventory";
            AllPartsDataGrid.Columns["Price"].HeaderText = "Price";
            AllPartsDataGrid.Columns["Min"].HeaderText = "Min";
            AllPartsDataGrid.Columns["Max"].HeaderText = "Max";

            var addParts = new BindingSource();
            addParts.DataSource = Product.AssociatedParts;
            AssociatedPartsDGV.DataSource = addParts;

            AssociatedPartsDGV.Columns["PartID"].HeaderText = "Part ID";
            AssociatedPartsDGV.Columns["Name"].HeaderText = "Part Name";
            AssociatedPartsDGV.Columns["InStock"].HeaderText = "Inventory";
            AssociatedPartsDGV.Columns["Price"].HeaderText = "Price";
            AssociatedPartsDGV.Columns["Min"].HeaderText = "Min";
            AssociatedPartsDGV.Columns["Max"].HeaderText = "Max";
        }

        // Add product methods //


        private void VerifyProductSave()
        {
            int productID = Inventory.Products[Inventory.Products.Count + 1].ProductID + 1;
            Product newProduct = new Product(productID, AddProdNameTextBox.Text, decimal.Parse(AddProdPriceTextBox.Text), int.Parse(AddProdInvTextBox.Text), 
            int.Parse(AddProdMinTextBox.Text), int.Parse(AddProdMaxTextBox.Text));
            Inventory.addProduct(newProduct);
            this.Close();
        }

        private void SaveProductButton_Click(object sender, EventArgs e)
        {
            VerifyProductSave();
        }


        //

        private void AddPartButton_Click(object sender, EventArgs e)
        {
            Part addedPart = (Part)AllPartsDataGrid.CurrentRow.DataBoundItem;
            Product.AssociatedParts.Add(addedPart);
        }

        private void DeletePartButton_Click(object sender, EventArgs e)
        {
            if (Product.AssociatedParts.Count > 0)
            {
                int partID = int.Parse(AssociatedPartsDGV.Rows[AssociatedPartsDGV.CurrentCell.RowIndex].Cells[0].Value.ToString());
                Product.RemoveAssociatedPart(partID);
            }
        }


        //


    }
}
