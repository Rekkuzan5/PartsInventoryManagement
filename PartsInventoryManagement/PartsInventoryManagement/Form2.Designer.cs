namespace PartsInventoryManagement
{
    partial class Form2
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
            this.ModifyPartLabel = new System.Windows.Forms.Label();
            this.InHouseRadButton = new System.Windows.Forms.RadioButton();
            this.OutRadButton = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
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
            this.ModifyPartLabel.Click += new System.EventHandler(this.ModifyPartLabel_Click);
            // 
            // InHouseRadButton
            // 
            this.InHouseRadButton.AutoSize = true;
            this.InHouseRadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InHouseRadButton.Location = new System.Drawing.Point(18, 62);
            this.InHouseRadButton.Name = "InHouseRadButton";
            this.InHouseRadButton.Size = new System.Drawing.Size(93, 24);
            this.InHouseRadButton.TabIndex = 1;
            this.InHouseRadButton.TabStop = true;
            this.InHouseRadButton.Text = "In-House";
            this.InHouseRadButton.UseVisualStyleBackColor = true;
            // 
            // OutRadButton
            // 
            this.OutRadButton.AutoSize = true;
            this.OutRadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutRadButton.Location = new System.Drawing.Point(18, 105);
            this.OutRadButton.Name = "OutRadButton";
            this.OutRadButton.Size = new System.Drawing.Size(110, 24);
            this.OutRadButton.TabIndex = 1;
            this.OutRadButton.TabStop = true;
            this.OutRadButton.Text = "Outsourced";
            this.OutRadButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(332, 65);
            this.textBox1.MinimumSize = new System.Drawing.Size(0, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 31);
            this.textBox1.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 682);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.OutRadButton);
            this.Controls.Add(this.InHouseRadButton);
            this.Controls.Add(this.ModifyPartLabel);
            this.Name = "Form2";
            this.Text = "Modify Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ModifyPartLabel;
        private System.Windows.Forms.RadioButton InHouseRadButton;
        private System.Windows.Forms.RadioButton OutRadButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}