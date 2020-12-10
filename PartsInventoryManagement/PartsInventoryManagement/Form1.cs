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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // bind to datagridview for parts
            var sourcePart = new BindingSource();
            sourcePart.DataSource = Inventory.AllParts;
            partsDataGridView.DataSource = sourcePart;

            // bind datagridview for products
            var sourceProduct = new BindingSource();
            sourceProduct.DataSource = Inventory.Products;
            ProductPataGridView.DataSource = sourceProduct;

            // Create column headers for parts datagridview
            partsDataGridView.Columns["PartID"].HeaderText = "Part ID";
            partsDataGridView.Columns["Name"].HeaderText = "Part Name";
            partsDataGridView.Columns["InStock"].HeaderText = "Inventory";
            partsDataGridView.Columns["Price"].HeaderText = "Price";
            partsDataGridView.Columns["Min"].Visible = false;
            partsDataGridView.Columns["Max"].Visible = false;

            // Create column headers for parts datagridview
            ProductPataGridView.Columns["ProductID"].HeaderText = "Product ID";
            ProductPataGridView.Columns["Name"].HeaderText = "Name";
            ProductPataGridView.Columns["InStock"].HeaderText = "Inventory";
            ProductPataGridView.Columns["Price"].HeaderText = "Price";
            ProductPataGridView.Columns["Min"].Visible = false;
            ProductPataGridView.Columns["Max"].Visible = false;

            Inventory.PopulateList();
            
        }

        // Opens new form to add a new part
        private void AddPartButton_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        // Opens a new form to modify an existing part
        private void ModifyPartButton_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        // Delete datagridviewrow on main page
        private void DeletePartButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in partsDataGridView.SelectedRows)
            {
                partsDataGridView.Rows.RemoveAt(row.Index);
            }
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {

        }

        private void ModifyProductButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteProductButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in ProductPataGridView.SelectedRows)
            {
                ProductPataGridView.Rows.RemoveAt(row.Index);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
