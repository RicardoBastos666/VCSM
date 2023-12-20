namespace VCSM
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.cmbThickness = new System.Windows.Forms.ComboBox();
            this.cmbRegion = new System.Windows.Forms.ComboBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblThikness = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblWarning = new System.Windows.Forms.Label();
            this.lblCalculatedPallets = new System.Windows.Forms.Label();
            this.dataGridViewCargo = new System.Windows.Forms.DataGridView();
            this.materialPropertiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialPropertiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbProduct
            // 
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(11, 96);
            this.cmbProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(134, 21);
            this.cmbProduct.TabIndex = 0;
            // 
            // cmbThickness
            // 
            this.cmbThickness.FormattingEnabled = true;
            this.cmbThickness.Location = new System.Drawing.Point(149, 96);
            this.cmbThickness.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbThickness.Name = "cmbThickness";
            this.cmbThickness.Size = new System.Drawing.Size(134, 21);
            this.cmbThickness.TabIndex = 1;
            // 
            // cmbRegion
            // 
            this.cmbRegion.FormattingEnabled = true;
            this.cmbRegion.Location = new System.Drawing.Point(11, 24);
            this.cmbRegion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbRegion.Name = "cmbRegion";
            this.cmbRegion.Size = new System.Drawing.Size(128, 21);
            this.cmbRegion.TabIndex = 2;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(8, 81);
            this.lblProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(44, 13);
            this.lblProduct.TabIndex = 3;
            this.lblProduct.Text = "Product";
            // 
            // lblThikness
            // 
            this.lblThikness.AutoSize = true;
            this.lblThikness.Location = new System.Drawing.Point(146, 81);
            this.lblThikness.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThikness.Name = "lblThikness";
            this.lblThikness.Size = new System.Drawing.Size(56, 13);
            this.lblThikness.TabIndex = 4;
            this.lblThikness.Text = "Thickness";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(11, 9);
            this.lblRegion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(41, 13);
            this.lblRegion.TabIndex = 5;
            this.lblRegion.Text = "Region";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(287, 97);
            this.txtWidth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(120, 20);
            this.txtWidth.TabIndex = 6;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(411, 97);
            this.txtLength.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(120, 20);
            this.txtLength.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Width";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(408, 81);
            this.lblLength.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(40, 13);
            this.lblLength.TabIndex = 9;
            this.lblLength.Text = "Length";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(659, 97);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(133, 21);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "Add to Cargo";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(532, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "QTY";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(535, 97);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(120, 20);
            this.txtQuantity.TabIndex = 16;
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Location = new System.Drawing.Point(146, 24);
            this.lblWarning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(35, 13);
            this.lblWarning.TabIndex = 17;
            this.lblWarning.Text = "label2";
            // 
            // lblCalculatedPallets
            // 
            this.lblCalculatedPallets.AutoSize = true;
            this.lblCalculatedPallets.Location = new System.Drawing.Point(146, 37);
            this.lblCalculatedPallets.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCalculatedPallets.Name = "lblCalculatedPallets";
            this.lblCalculatedPallets.Size = new System.Drawing.Size(35, 13);
            this.lblCalculatedPallets.TabIndex = 18;
            this.lblCalculatedPallets.Text = "label2";
            // 
            // dataGridViewCargo
            // 
            this.dataGridViewCargo.AllowUserToDeleteRows = false;
            this.dataGridViewCargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCargo.Location = new System.Drawing.Point(8, 121);
            this.dataGridViewCargo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewCargo.Name = "dataGridViewCargo";
            this.dataGridViewCargo.ReadOnly = true;
            this.dataGridViewCargo.RowHeadersWidth = 62;
            this.dataGridViewCargo.RowTemplate.Height = 28;
            this.dataGridViewCargo.Size = new System.Drawing.Size(784, 239);
            this.dataGridViewCargo.TabIndex = 19;
            // 
            // materialPropertiesBindingSource
            // 
            this.materialPropertiesBindingSource.DataSource = typeof(VCSM.Data.CargoData.MaterialProperties);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.dataGridViewCargo);
            this.Controls.Add(this.lblCalculatedPallets);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.lblThikness);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.cmbRegion);
            this.Controls.Add(this.cmbThickness);
            this.Controls.Add(this.cmbProduct);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialPropertiesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.ComboBox cmbThickness;
        private System.Windows.Forms.ComboBox cmbRegion;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblThikness;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Label lblCalculatedPallets;
        private System.Windows.Forms.DataGridView dataGridViewCargo;
        private System.Windows.Forms.BindingSource materialPropertiesBindingSource;
    }
}

