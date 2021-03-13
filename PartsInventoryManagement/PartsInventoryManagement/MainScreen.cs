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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            MainScreenLoad();            
        }

        public void MainScreenLoad()
        {
            // bind to datagridview for parts
            var sourcePart = new BindingSource();
            sourcePart.DataSource = Inventory.AllParts;
            partsDataGridView.DataSource = sourcePart;

            // bind datagridview for products
            var sourceProduct = new BindingSource();
            sourceProduct.DataSource = Inventory.Products;
            ProductDataGridView.DataSource = sourceProduct;

            // Create column headers for parts datagridview
            partsDataGridView.Columns["PartID"].HeaderText = "Part ID";
            partsDataGridView.Columns["Name"].HeaderText = "Part Name";
            partsDataGridView.Columns["InStock"].HeaderText = "Inventory";
            partsDataGridView.Columns["Price"].HeaderText = "Price";
            partsDataGridView.Columns["Min"].HeaderText = "Min";
            partsDataGridView.Columns["Max"].HeaderText = "Max";

            // Create column headers for parts datagridview
            ProductDataGridView.Columns["ProductID"].HeaderText = "Product ID";
            ProductDataGridView.Columns["Name"].HeaderText = "Name";
            ProductDataGridView.Columns["InStock"].HeaderText = "Inventory";
            ProductDataGridView.Columns["Price"].HeaderText = "Price";
            ProductDataGridView.Columns["Min"].HeaderText = "Min";
            ProductDataGridView.Columns["Max"].HeaderText = "Max";

            Inventory.PopulateList();
        }
    
        // Parts functions for main page

        // Opens new form to add a new part
        private void AddPartButton_Click(object sender, EventArgs e)
        {
            AddPart addNewPart = new AddPart();
            addNewPart.ShowDialog();
        }

        // Opens a new form to modify an existing part based on the type of object and update main screen.
        private void ModifyPartButton_Click(object sender, EventArgs e)
        {
            if (Inventory.AllParts.Count > 0)
            {
                if (partsDataGridView.CurrentRow.DataBoundItem.GetType() == typeof(InHouse))
                {
                    InHouse housePart = (InHouse)partsDataGridView.CurrentRow.DataBoundItem;
                    new ModifyPart(housePart).ShowDialog();
                }
                else if (partsDataGridView.CurrentRow.DataBoundItem.GetType() == typeof(Outsourced))
                {
                    Outsourced outsidePart = (Outsourced)partsDataGridView.CurrentRow.DataBoundItem;
                    new ModifyPart(outsidePart).ShowDialog();
                }
            }
            this.Refresh();
        }

        // Delete part in grid on main page
        private void DeletePartButton_Click(object sender, EventArgs e)
        {
            if (Inventory.AllParts.Count > 0)
            { 
                var result = MessageBox.Show("Are you sure you want to delete this part?", "Delete Part", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int partID = int.Parse(partsDataGridView.Rows[partsDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString());
                    Inventory.DeletePart(partID);
                    this.Refresh();
                }
            }
        }

        // search for a part based on part name.
        private void PartSearchButton_Click(object sender, EventArgs e)
        {
            if (searchPartTextBox1.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.ToUpper().Contains(searchPartTextBox1.Text.ToUpper()))
                    {
                        int searchpart = Inventory.AllParts[i].PartID;
                        Part partFound = Inventory.LookupPart(searchpart);

                        foreach (DataGridViewRow row in partsDataGridView.Rows)
                        {
                            Part part = (Part)row.DataBoundItem;
                            if (part.PartID == partFound.PartID)
                            {
                                row.Selected = true;
                                break;
                            }
                            else
                            {
                                row.Selected = false;
                            }
                        }
                    }
                }             
            }
        }

        // Products functions for main page

        //  Opens new form to add a new product
        private void AddProductButton_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.ShowDialog();
        }

        // Opens new form to modify products
        private void ModifyProductButton_Click(object sender, EventArgs e)
        {
            if (Inventory.Products.Count > 0)
            { 
                if (ProductDataGridView.CurrentRow.DataBoundItem.GetType() == typeof(Product))
                {
                    Product moddedProduct = (Product)ProductDataGridView.CurrentRow.DataBoundItem;
                    new ModifyProduct(moddedProduct).ShowDialog();
                }
            }
            this.Refresh();
        }

        // Delete product in grid on main page
        private void DeleteProductButton_Click(object sender, EventArgs e)
        {
            if (Inventory.Products.Count > 0)
            {
                var result = MessageBox.Show("Are you sure you want to delete this product?", "Delete Product", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in ProductDataGridView.SelectedRows)
                    {
                        int productID = int.Parse(ProductDataGridView.Rows[ProductDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString());
                    Inventory.RemoveProduct(productID);
                    }
                }
            }
            this.Refresh();
        }

        // search for a product based on product name.
        private void ProductSearchButton_Click(object sender, EventArgs e)
        {
            if (searchProductTextBox.Text != "")
            {
                for (int i = 0; i < Inventory.Products.Count; i++)
                {
                    if (Inventory.Products[i].Name.ToUpper().Contains(searchProductTextBox.Text.ToUpper()))
                    {
                        int searchProduct = Inventory.Products[i].ProductID;
                        Product productFound = Inventory.LookupProduct(searchProduct);

                        foreach (DataGridViewRow row in ProductDataGridView.Rows)
                        {
                            Product prod = (Product)row.DataBoundItem;
                            if (prod.ProductID == productFound.ProductID)
                            {
                                row.Selected = true;
                                break;
                            }
                            else
                            {
                                row.Selected = false;
                            }
                        }
                    }
                }
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
