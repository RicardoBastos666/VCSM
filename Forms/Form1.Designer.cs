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
            this.label4 = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblWarning = new System.Windows.Forms.Label();
            this.dataGridViewCargo = new System.Windows.Forms.DataGridView();
            this.materialPropertiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLength = new System.Windows.Forms.NumericUpDown();
            this.lblTotalWeight = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialPropertiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLength)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbProduct
            // 
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(16, 148);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(199, 28);
            this.cmbProduct.TabIndex = 0;
            // 
            // cmbThickness
            // 
            this.cmbThickness.FormattingEnabled = true;
            this.cmbThickness.Location = new System.Drawing.Point(224, 148);
            this.cmbThickness.Name = "cmbThickness";
            this.cmbThickness.Size = new System.Drawing.Size(199, 28);
            this.cmbThickness.TabIndex = 1;
            // 
            // cmbRegion
            // 
            this.cmbRegion.FormattingEnabled = true;
            this.cmbRegion.Location = new System.Drawing.Point(16, 37);
            this.cmbRegion.Name = "cmbRegion";
            this.cmbRegion.Size = new System.Drawing.Size(190, 28);
            this.cmbRegion.TabIndex = 2;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(12, 125);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(64, 20);
            this.lblProduct.TabIndex = 3;
            this.lblProduct.Text = "Product";
            // 
            // lblThikness
            // 
            this.lblThikness.AutoSize = true;
            this.lblThikness.Location = new System.Drawing.Point(219, 125);
            this.lblThikness.Name = "lblThikness";
            this.lblThikness.Size = new System.Drawing.Size(80, 20);
            this.lblThikness.TabIndex = 4;
            this.lblThikness.Text = "Thickness";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(16, 14);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(60, 20);
            this.lblRegion.TabIndex = 5;
            this.lblRegion.Text = "Region";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(426, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Width";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(612, 125);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(59, 20);
            this.lblLength.TabIndex = 9;
            this.lblLength.Text = "Length";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(988, 149);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(200, 32);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "Add to Cargo";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(798, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "QTY";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(802, 149);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(178, 26);
            this.txtQuantity.TabIndex = 16;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Location = new System.Drawing.Point(219, 37);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(51, 20);
            this.lblWarning.TabIndex = 17;
            this.lblWarning.Text = "label2";
            // 
            // dataGridViewCargo
            // 
            this.dataGridViewCargo.AllowUserToDeleteRows = false;
            this.dataGridViewCargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCargo.Location = new System.Drawing.Point(12, 186);
            this.dataGridViewCargo.Name = "dataGridViewCargo";
            this.dataGridViewCargo.ReadOnly = true;
            this.dataGridViewCargo.RowHeadersWidth = 62;
            this.dataGridViewCargo.RowTemplate.Height = 28;
            this.dataGridViewCargo.Size = new System.Drawing.Size(1176, 368);
            this.dataGridViewCargo.TabIndex = 19;
            // 
            // materialPropertiesBindingSource
            // 
            this.materialPropertiesBindingSource.DataSource = typeof(VCSM.Data.CargoData.MaterialProperties);
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Location = new System.Drawing.Point(432, 148);
            this.numericUpDownWidth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(180, 26);
            this.numericUpDownWidth.TabIndex = 20;
            this.numericUpDownWidth.ValueChanged += new System.EventHandler(this.numericUpDownLength_ValueChanged);
            // 
            // numericUpDownLength
            // 
            this.numericUpDownLength.Location = new System.Drawing.Point(616, 148);
            this.numericUpDownLength.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownLength.Name = "numericUpDownLength";
            this.numericUpDownLength.Size = new System.Drawing.Size(180, 26);
            this.numericUpDownLength.TabIndex = 21;
            this.numericUpDownLength.ValueChanged += new System.EventHandler(this.numericUpDownLenght_ValueChanged);
            // 
            // lblTotalWeight
            // 
            this.lblTotalWeight.AutoSize = true;
            this.lblTotalWeight.Location = new System.Drawing.Point(12, 569);
            this.lblTotalWeight.Name = "lblTotalWeight";
            this.lblTotalWeight.Size = new System.Drawing.Size(0, 20);
            this.lblTotalWeight.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1896, 1048);
            this.Controls.Add(this.lblTotalWeight);
            this.Controls.Add(this.numericUpDownLength);
            this.Controls.Add(this.numericUpDownWidth);
            this.Controls.Add(this.dataGridViewCargo);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.lblThikness);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.cmbRegion);
            this.Controls.Add(this.cmbThickness);
            this.Controls.Add(this.cmbProduct);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialPropertiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLength)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.DataGridView dataGridViewCargo;
        private System.Windows.Forms.BindingSource materialPropertiesBindingSource;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownLength;
        private System.Windows.Forms.Label lblTotalWeight;
    }
}

