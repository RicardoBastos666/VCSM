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
            this.btnAddToCargo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblWarning = new System.Windows.Forms.Label();
            this.dataGridViewCargo = new System.Windows.Forms.DataGridView();
            this.materialPropertiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLength = new System.Windows.Forms.NumericUpDown();
            this.lblTotalWeight = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnFinishOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialPropertiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLength)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbProduct
            // 
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(11, 96);
            this.cmbProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(134, 21);
            this.cmbProduct.TabIndex = 1;
            // 
            // cmbThickness
            // 
            this.cmbThickness.FormattingEnabled = true;
            this.cmbThickness.Location = new System.Drawing.Point(149, 96);
            this.cmbThickness.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbThickness.Name = "cmbThickness";
            this.cmbThickness.Size = new System.Drawing.Size(134, 21);
            this.cmbThickness.TabIndex = 2;
            // 
            // cmbRegion
            // 
            this.cmbRegion.FormattingEnabled = true;
            this.cmbRegion.Location = new System.Drawing.Point(11, 24);
            this.cmbRegion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbRegion.Name = "cmbRegion";
            this.cmbRegion.Size = new System.Drawing.Size(128, 21);
            this.cmbRegion.TabIndex = 0;
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
            // btnAddToCargo
            // 
            this.btnAddToCargo.Location = new System.Drawing.Point(659, 97);
            this.btnAddToCargo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddToCargo.Name = "btnAddToCargo";
            this.btnAddToCargo.Size = new System.Drawing.Size(133, 21);
            this.btnAddToCargo.TabIndex = 6;
            this.btnAddToCargo.Text = "Add to Cargo";
            this.btnAddToCargo.UseVisualStyleBackColor = true;
            this.btnAddToCargo.Click += new System.EventHandler(this.btnCalculate_Click);
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
            this.txtQuantity.TabIndex = 5;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
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
            this.dataGridViewCargo.TabIndex = 8;
            // 
            // materialPropertiesBindingSource
            // 
            this.materialPropertiesBindingSource.DataSource = typeof(VCSM.Data.CargoData.MaterialProperties);
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Location = new System.Drawing.Point(288, 96);
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownWidth.TabIndex = 3;
            this.numericUpDownWidth.ValueChanged += new System.EventHandler(this.numericUpDownLength_ValueChanged);
            // 
            // numericUpDownLength
            // 
            this.numericUpDownLength.Location = new System.Drawing.Point(411, 96);
            this.numericUpDownLength.Name = "numericUpDownLength";
            this.numericUpDownLength.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownLength.TabIndex = 4;
            this.numericUpDownLength.ValueChanged += new System.EventHandler(this.numericUpDownLenght_ValueChanged);
            // 
            // lblTotalWeight
            // 
            this.lblTotalWeight.AutoSize = true;
            this.lblTotalWeight.Location = new System.Drawing.Point(8, 370);
            this.lblTotalWeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalWeight.Name = "lblTotalWeight";
            this.lblTotalWeight.Size = new System.Drawing.Size(0, 13);
            this.lblTotalWeight.TabIndex = 22;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(535, 364);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(133, 19);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove Line";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnFinishOrder
            // 
            this.btnFinishOrder.Location = new System.Drawing.Point(672, 364);
            this.btnFinishOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFinishOrder.Name = "btnFinishOrder";
            this.btnFinishOrder.Size = new System.Drawing.Size(120, 19);
            this.btnFinishOrder.TabIndex = 23;
            this.btnFinishOrder.Text = "Finish Order";
            this.btnFinishOrder.UseVisualStyleBackColor = true;
            this.btnFinishOrder.Click += new System.EventHandler(this.btnFinishOrder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnFinishOrder);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblTotalWeight);
            this.Controls.Add(this.numericUpDownLength);
            this.Controls.Add(this.numericUpDownWidth);
            this.Controls.Add(this.dataGridViewCargo);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddToCargo);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Button btnAddToCargo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.DataGridView dataGridViewCargo;
        private System.Windows.Forms.BindingSource materialPropertiesBindingSource;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownLength;
        private System.Windows.Forms.Label lblTotalWeight;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnFinishOrder;
    }
}

