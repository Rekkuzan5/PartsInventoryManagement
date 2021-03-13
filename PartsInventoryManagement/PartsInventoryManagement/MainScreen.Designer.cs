namespace PartsInventoryManagement
{
    partial class MainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.AddPartButton = new System.Windows.Forms.Button();
            this.ModifyPartButton = new System.Windows.Forms.Button();
            this.DeletePartButton = new System.Windows.Forms.Button();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.ModifyProductButton = new System.Windows.Forms.Button();
            this.DeleteProductButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.partsDataGridView = new System.Windows.Forms.DataGridView();
            this.ProductDataGridView = new System.Windows.Forms.DataGridView();
            this.searchPartTextBox1 = new System.Windows.Forms.TextBox();
            this.searchProductTextBox = new System.Windows.Forms.TextBox();
            this.PartSearchButton = new System.Windows.Forms.Button();
            this.ProductSearchButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Management System";
            // 
            // AddPartButton
            // 
            this.AddPartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartButton.Location = new System.Drawing.Point(403, 505);
            this.AddPartButton.Name = "AddPartButton";
            this.AddPartButton.Size = new System.Drawing.Size(80, 30);
            this.AddPartButton.TabIndex = 1;
            this.AddPartButton.Text = "Add";
            this.AddPartButton.UseVisualStyleBackColor = true;
            this.AddPartButton.Click += new System.EventHandler(this.AddPartButton_Click);
            // 
            // ModifyPartButton
            // 
            this.ModifyPartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyPartButton.Location = new System.Drawing.Point(489, 505);
            this.ModifyPartButton.Name = "ModifyPartButton";
            this.ModifyPartButton.Size = new System.Drawing.Size(80, 30);
            this.ModifyPartButton.TabIndex = 1;
            this.ModifyPartButton.Text = "Modify";
            this.ModifyPartButton.UseVisualStyleBackColor = true;
            this.ModifyPartButton.Click += new System.EventHandler(this.ModifyPartButton_Click);
            // 
            // DeletePartButton
            // 
            this.DeletePartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletePartButton.Location = new System.Drawing.Point(575, 505);
            this.DeletePartButton.Name = "DeletePartButton";
            this.DeletePartButton.Size = new System.Drawing.Size(80, 30);
            this.DeletePartButton.TabIndex = 1;
            this.DeletePartButton.Text = "Delete";
            this.DeletePartButton.UseVisualStyleBackColor = true;
            this.DeletePartButton.Click += new System.EventHandler(this.DeletePartButton_Click);
            // 
            // AddProductButton
            // 
            this.AddProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductButton.Location = new System.Drawing.Point(1086, 505);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(80, 30);
            this.AddProductButton.TabIndex = 1;
            this.AddProductButton.Text = "Add";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // ModifyProductButton
            // 
            this.ModifyProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyProductButton.Location = new System.Drawing.Point(1172, 505);
            this.ModifyProductButton.Name = "ModifyProductButton";
            this.ModifyProductButton.Size = new System.Drawing.Size(80, 30);
            this.ModifyProductButton.TabIndex = 1;
            this.ModifyProductButton.Text = "Modify";
            this.ModifyProductButton.UseVisualStyleBackColor = true;
            this.ModifyProductButton.Click += new System.EventHandler(this.ModifyProductButton_Click);
            // 
            // DeleteProductButton
            // 
            this.DeleteProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteProductButton.Location = new System.Drawing.Point(1258, 505);
            this.DeleteProductButton.Name = "DeleteProductButton";
            this.DeleteProductButton.Size = new System.Drawing.Size(80, 30);
            this.DeleteProductButton.TabIndex = 1;
            this.DeleteProductButton.Text = "Delete";
            this.DeleteProductButton.UseVisualStyleBackColor = true;
            this.DeleteProductButton.Click += new System.EventHandler(this.DeleteProductButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(1253, 610);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(80, 30);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // partsDataGridView
            // 
            this.partsDataGridView.AllowUserToAddRows = false;
            this.partsDataGridView.AllowUserToDeleteRows = false;
            this.partsDataGridView.AllowUserToResizeRows = false;
            this.partsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.partsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.partsDataGridView.ColumnHeadersHeight = 30;
            this.partsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.partsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.partsDataGridView.EnableHeadersVisualStyles = false;
            this.partsDataGridView.Location = new System.Drawing.Point(97, 170);
            this.partsDataGridView.MultiSelect = false;
            this.partsDataGridView.Name = "partsDataGridView";
            this.partsDataGridView.ReadOnly = true;
            this.partsDataGridView.RowHeadersVisible = false;
            this.partsDataGridView.RowHeadersWidth = 51;
            this.partsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.partsDataGridView.RowTemplate.Height = 30;
            this.partsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partsDataGridView.ShowRowErrors = false;
            this.partsDataGridView.Size = new System.Drawing.Size(570, 300);
            this.partsDataGridView.TabIndex = 3;
            // 
            // ProductDataGridView
            // 
            this.ProductDataGridView.AllowUserToAddRows = false;
            this.ProductDataGridView.AllowUserToDeleteRows = false;
            this.ProductDataGridView.AllowUserToResizeRows = false;
            this.ProductDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ProductDataGridView.ColumnHeadersHeight = 30;
            this.ProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.ProductDataGridView.EnableHeadersVisualStyles = false;
            this.ProductDataGridView.Location = new System.Drawing.Point(763, 170);
            this.ProductDataGridView.MultiSelect = false;
            this.ProductDataGridView.Name = "ProductDataGridView";
            this.ProductDataGridView.ReadOnly = true;
            this.ProductDataGridView.RowHeadersVisible = false;
            this.ProductDataGridView.RowHeadersWidth = 51;
            this.ProductDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ProductDataGridView.RowTemplate.Height = 30;
            this.ProductDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductDataGridView.ShowEditingIcon = false;
            this.ProductDataGridView.Size = new System.Drawing.Size(570, 300);
            this.ProductDataGridView.TabIndex = 3;
            // 
            // searchPartTextBox1
            // 
            this.searchPartTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPartTextBox1.Location = new System.Drawing.Point(415, 108);
            this.searchPartTextBox1.MinimumSize = new System.Drawing.Size(170, 30);
            this.searchPartTextBox1.Name = "searchPartTextBox1";
            this.searchPartTextBox1.Size = new System.Drawing.Size(252, 29);
            this.searchPartTextBox1.TabIndex = 4;
            // 
            // searchProductTextBox
            // 
            this.searchProductTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchProductTextBox.Location = new System.Drawing.Point(1081, 108);
            this.searchProductTextBox.MinimumSize = new System.Drawing.Size(170, 30);
            this.searchProductTextBox.Name = "searchProductTextBox";
            this.searchProductTextBox.Size = new System.Drawing.Size(252, 29);
            this.searchProductTextBox.TabIndex = 4;
            // 
            // PartSearchButton
            // 
            this.PartSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartSearchButton.Location = new System.Drawing.Point(329, 108);
            this.PartSearchButton.Name = "PartSearchButton";
            this.PartSearchButton.Size = new System.Drawing.Size(80, 30);
            this.PartSearchButton.TabIndex = 5;
            this.PartSearchButton.Text = "Search";
            this.PartSearchButton.UseVisualStyleBackColor = true;
            this.PartSearchButton.Click += new System.EventHandler(this.PartSearchButton_Click);
            // 
            // ProductSearchButton
            // 
            this.ProductSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductSearchButton.Location = new System.Drawing.Point(995, 108);
            this.ProductSearchButton.Name = "ProductSearchButton";
            this.ProductSearchButton.Size = new System.Drawing.Size(80, 30);
            this.ProductSearchButton.TabIndex = 5;
            this.ProductSearchButton.Text = "Search";
            this.ProductSearchButton.UseVisualStyleBackColor = true;
            this.ProductSearchButton.Click += new System.EventHandler(this.ProductSearchButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Parts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(762, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Products";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 677);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProductSearchButton);
            this.Controls.Add(this.PartSearchButton);
            this.Controls.Add(this.searchProductTextBox);
            this.Controls.Add(this.searchPartTextBox1);
            this.Controls.Add(this.ProductDataGridView);
            this.Controls.Add(this.partsDataGridView);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DeleteProductButton);
            this.Controls.Add(this.ModifyProductButton);
            this.Controls.Add(this.DeletePartButton);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.ModifyPartButton);
            this.Controls.Add(this.AddPartButton);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1440, 716);
            this.MinimumSize = new System.Drawing.Size(1440, 716);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management System - Main";
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddPartButton;
        private System.Windows.Forms.Button ModifyPartButton;
        private System.Windows.Forms.Button DeletePartButton;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Button ModifyProductButton;
        private System.Windows.Forms.Button DeleteProductButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.DataGridView partsDataGridView;
        private System.Windows.Forms.DataGridView ProductDataGridView;
        private System.Windows.Forms.TextBox searchPartTextBox1;
        private System.Windows.Forms.TextBox searchProductTextBox;
        private System.Windows.Forms.Button PartSearchButton;
        private System.Windows.Forms.Button ProductSearchButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

