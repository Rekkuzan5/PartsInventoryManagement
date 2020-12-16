namespace PartsInventoryManagement
{
    partial class ModifyPart
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
            this.modifyPartCancelButton = new System.Windows.Forms.Button();
            this.partSaveButton = new System.Windows.Forms.Button();
            this.partMachineIDLabel = new System.Windows.Forms.Label();
            this.partMinLabel = new System.Windows.Forms.Label();
            this.partMaxLabel = new System.Windows.Forms.Label();
            this.partPriceLabel = new System.Windows.Forms.Label();
            this.partInventoryLabel = new System.Windows.Forms.Label();
            this.partNameLabel = new System.Windows.Forms.Label();
            this.partIDLabel = new System.Windows.Forms.Label();
            this.modMachineIDTextBox = new System.Windows.Forms.TextBox();
            this.modInventoryTextBox = new System.Windows.Forms.TextBox();
            this.modMaxTextBox = new System.Windows.Forms.TextBox();
            this.modNameTextBox = new System.Windows.Forms.TextBox();
            this.modMinTextBox = new System.Windows.Forms.TextBox();
            this.modPartIDTextBox = new System.Windows.Forms.TextBox();
            this.OutsourcedRadButton = new System.Windows.Forms.RadioButton();
            this.InHouseRadButton = new System.Windows.Forms.RadioButton();
            this.ModifyPartLabel = new System.Windows.Forms.Label();
            this.modPriceTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // modifyPartCancelButton
            // 
            this.modifyPartCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPartCancelButton.Location = new System.Drawing.Point(489, 557);
            this.modifyPartCancelButton.Name = "modifyPartCancelButton";
            this.modifyPartCancelButton.Size = new System.Drawing.Size(80, 30);
            this.modifyPartCancelButton.TabIndex = 17;
            this.modifyPartCancelButton.Text = "Cancel";
            this.modifyPartCancelButton.UseVisualStyleBackColor = true;
            this.modifyPartCancelButton.Click += new System.EventHandler(this.modifyPartCancelButton_Click);
            // 
            // partSaveButton
            // 
            this.partSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partSaveButton.Location = new System.Drawing.Point(358, 557);
            this.partSaveButton.Name = "partSaveButton";
            this.partSaveButton.Size = new System.Drawing.Size(80, 30);
            this.partSaveButton.TabIndex = 16;
            this.partSaveButton.Text = "Save";
            this.partSaveButton.UseVisualStyleBackColor = true;
            this.partSaveButton.Click += new System.EventHandler(this.Partsavebutton_click);
            // 
            // partMachineIDLabel
            // 
            this.partMachineIDLabel.AutoSize = true;
            this.partMachineIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partMachineIDLabel.Location = new System.Drawing.Point(138, 493);
            this.partMachineIDLabel.Name = "partMachineIDLabel";
            this.partMachineIDLabel.Size = new System.Drawing.Size(90, 20);
            this.partMachineIDLabel.TabIndex = 15;
            this.partMachineIDLabel.Text = "Machine ID";
            // 
            // partMinLabel
            // 
            this.partMinLabel.AutoSize = true;
            this.partMinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partMinLabel.Location = new System.Drawing.Point(404, 422);
            this.partMinLabel.Name = "partMinLabel";
            this.partMinLabel.Size = new System.Drawing.Size(34, 20);
            this.partMinLabel.TabIndex = 14;
            this.partMinLabel.Text = "Min";
            // 
            // partMaxLabel
            // 
            this.partMaxLabel.AutoSize = true;
            this.partMaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partMaxLabel.Location = new System.Drawing.Point(190, 422);
            this.partMaxLabel.Name = "partMaxLabel";
            this.partMaxLabel.Size = new System.Drawing.Size(38, 20);
            this.partMaxLabel.TabIndex = 13;
            this.partMaxLabel.Text = "Max";
            // 
            // partPriceLabel
            // 
            this.partPriceLabel.AutoSize = true;
            this.partPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partPriceLabel.Location = new System.Drawing.Point(139, 346);
            this.partPriceLabel.Name = "partPriceLabel";
            this.partPriceLabel.Size = new System.Drawing.Size(89, 20);
            this.partPriceLabel.TabIndex = 12;
            this.partPriceLabel.Text = "Price / Cost";
            // 
            // partInventoryLabel
            // 
            this.partInventoryLabel.AutoSize = true;
            this.partInventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partInventoryLabel.Location = new System.Drawing.Point(154, 269);
            this.partInventoryLabel.Name = "partInventoryLabel";
            this.partInventoryLabel.Size = new System.Drawing.Size(74, 20);
            this.partInventoryLabel.TabIndex = 11;
            this.partInventoryLabel.Text = "Inventory";
            // 
            // partNameLabel
            // 
            this.partNameLabel.AutoSize = true;
            this.partNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partNameLabel.Location = new System.Drawing.Point(177, 189);
            this.partNameLabel.Name = "partNameLabel";
            this.partNameLabel.Size = new System.Drawing.Size(51, 20);
            this.partNameLabel.TabIndex = 10;
            this.partNameLabel.Text = "Name";
            // 
            // partIDLabel
            // 
            this.partIDLabel.AutoSize = true;
            this.partIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partIDLabel.Location = new System.Drawing.Point(202, 109);
            this.partIDLabel.Name = "partIDLabel";
            this.partIDLabel.Size = new System.Drawing.Size(26, 20);
            this.partIDLabel.TabIndex = 9;
            this.partIDLabel.Text = "ID";
            // 
            // modMachineIDTextBox
            // 
            this.modMachineIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modMachineIDTextBox.Location = new System.Drawing.Point(272, 493);
            this.modMachineIDTextBox.Name = "modMachineIDTextBox";
            this.modMachineIDTextBox.Size = new System.Drawing.Size(194, 26);
            this.modMachineIDTextBox.TabIndex = 8;
            // 
            // modInventoryTextBox
            // 
            this.modInventoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modInventoryTextBox.Location = new System.Drawing.Point(272, 269);
            this.modInventoryTextBox.Name = "modInventoryTextBox";
            this.modInventoryTextBox.Size = new System.Drawing.Size(194, 26);
            this.modInventoryTextBox.TabIndex = 7;
            // 
            // modMaxTextBox
            // 
            this.modMaxTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modMaxTextBox.Location = new System.Drawing.Point(272, 422);
            this.modMaxTextBox.Name = "modMaxTextBox";
            this.modMaxTextBox.Size = new System.Drawing.Size(93, 26);
            this.modMaxTextBox.TabIndex = 6;
            // 
            // modNameTextBox
            // 
            this.modNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modNameTextBox.Location = new System.Drawing.Point(272, 189);
            this.modNameTextBox.Name = "modNameTextBox";
            this.modNameTextBox.Size = new System.Drawing.Size(194, 26);
            this.modNameTextBox.TabIndex = 4;
            // 
            // modMinTextBox
            // 
            this.modMinTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modMinTextBox.Location = new System.Drawing.Point(469, 422);
            this.modMinTextBox.Name = "modMinTextBox";
            this.modMinTextBox.Size = new System.Drawing.Size(100, 26);
            this.modMinTextBox.TabIndex = 3;
            // 
            // modPartIDTextBox
            // 
            this.modPartIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modPartIDTextBox.Location = new System.Drawing.Point(272, 103);
            this.modPartIDTextBox.Name = "modPartIDTextBox";
            this.modPartIDTextBox.Size = new System.Drawing.Size(194, 26);
            this.modPartIDTextBox.TabIndex = 2;
            // 
            // OutsourcedRadButton
            // 
            this.OutsourcedRadButton.AutoSize = true;
            this.OutsourcedRadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutsourcedRadButton.Location = new System.Drawing.Point(356, 17);
            this.OutsourcedRadButton.Name = "OutsourcedRadButton";
            this.OutsourcedRadButton.Size = new System.Drawing.Size(110, 24);
            this.OutsourcedRadButton.TabIndex = 1;
            this.OutsourcedRadButton.TabStop = true;
            this.OutsourcedRadButton.Text = "Outsourced";
            this.OutsourcedRadButton.UseVisualStyleBackColor = true;
            this.OutsourcedRadButton.CheckedChanged += new System.EventHandler(this.OutsourcedRadButton_CheckedChanged);
            // 
            // InHouseRadButton
            // 
            this.InHouseRadButton.AutoSize = true;
            this.InHouseRadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InHouseRadButton.Location = new System.Drawing.Point(206, 17);
            this.InHouseRadButton.Name = "InHouseRadButton";
            this.InHouseRadButton.Size = new System.Drawing.Size(93, 24);
            this.InHouseRadButton.TabIndex = 1;
            this.InHouseRadButton.TabStop = true;
            this.InHouseRadButton.Text = "In-House";
            this.InHouseRadButton.UseVisualStyleBackColor = true;
            // 
            // ModifyPartLabel
            // 
            this.ModifyPartLabel.AutoSize = true;
            this.ModifyPartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyPartLabel.Location = new System.Drawing.Point(12, 9);
            this.ModifyPartLabel.Name = "ModifyPartLabel";
            this.ModifyPartLabel.Size = new System.Drawing.Size(151, 31);
            this.ModifyPartLabel.TabIndex = 0;
            this.ModifyPartLabel.Text = "Modify Part";
            // 
            // modPriceTextBox
            // 
            this.modPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modPriceTextBox.Location = new System.Drawing.Point(272, 346);
            this.modPriceTextBox.Name = "modPriceTextBox";
            this.modPriceTextBox.Size = new System.Drawing.Size(194, 26);
            this.modPriceTextBox.TabIndex = 5;
            // 
            // ModifyPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 611);
            this.Controls.Add(this.modifyPartCancelButton);
            this.Controls.Add(this.partSaveButton);
            this.Controls.Add(this.partMachineIDLabel);
            this.Controls.Add(this.partMinLabel);
            this.Controls.Add(this.partMaxLabel);
            this.Controls.Add(this.partPriceLabel);
            this.Controls.Add(this.partInventoryLabel);
            this.Controls.Add(this.partNameLabel);
            this.Controls.Add(this.partIDLabel);
            this.Controls.Add(this.modMachineIDTextBox);
            this.Controls.Add(this.modInventoryTextBox);
            this.Controls.Add(this.modMaxTextBox);
            this.Controls.Add(this.modPriceTextBox);
            this.Controls.Add(this.modNameTextBox);
            this.Controls.Add(this.modMinTextBox);
            this.Controls.Add(this.modPartIDTextBox);
            this.Controls.Add(this.OutsourcedRadButton);
            this.Controls.Add(this.InHouseRadButton);
            this.Controls.Add(this.ModifyPartLabel);
            this.MaximumSize = new System.Drawing.Size(650, 650);
            this.MinimumSize = new System.Drawing.Size(650, 650);
            this.Name = "ModifyPart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modify Part";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button modifyPartCancelButton;
        private System.Windows.Forms.Button partSaveButton;
        private System.Windows.Forms.Label partMachineIDLabel;
        private System.Windows.Forms.Label partMinLabel;
        private System.Windows.Forms.Label partMaxLabel;
        private System.Windows.Forms.Label partPriceLabel;
        private System.Windows.Forms.Label partInventoryLabel;
        private System.Windows.Forms.Label partNameLabel;
        private System.Windows.Forms.Label partIDLabel;
        private System.Windows.Forms.TextBox modMachineIDTextBox;
        private System.Windows.Forms.TextBox modInventoryTextBox;
        private System.Windows.Forms.TextBox modMaxTextBox;
        private System.Windows.Forms.TextBox modNameTextBox;
        private System.Windows.Forms.TextBox modMinTextBox;
        private System.Windows.Forms.TextBox modPartIDTextBox;
        private System.Windows.Forms.RadioButton InHouseRadButton;
        private System.Windows.Forms.Label ModifyPartLabel;
        private System.Windows.Forms.TextBox modPriceTextBox;
        private System.Windows.Forms.RadioButton OutsourcedRadButton;
    }
}