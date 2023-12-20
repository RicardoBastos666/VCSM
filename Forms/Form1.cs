using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using VCSM.Data;

namespace VCSM
{
    public partial class Form1 : Form
    {
        private List<CargoItem> CargoList = new List<CargoItem>();

        public Form1()
        {
            InitializeComponent();
            InitializeDropdowns();
            InitializeDataGridView();
            InitializeWidthNumericUpDown();
            // Set the form size to 1280x720
            this.Size = new Size(1280, 720);

            // Prevent resizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void InitializeWidthNumericUpDown()
        {
            // Assuming you have a NumericUpDown control named numericUpDownWidth
            // Set the minimum and maximum values for the width
            numericUpDownLength.Minimum = 2299;  // Adjust this based on your minimum allowed width
            numericUpDownLength.Maximum = 2743;  // Adjust this based on your maximum allowed width
            numericUpDownWidth.Maximum = 2300;
            numericUpDownWidth.Minimum = 0;
            // Set the default value or adjust the increment based on your requirements
            numericUpDownWidth.Value = 2299;  // Default value
            numericUpDownWidth.Increment = 1;  // Increment value

            // Optionally, handle the ValueChanged event to perform additional actions when the value changes
            numericUpDownWidth.ValueChanged += numericUpDownWidth_ValueChanged;
        }
        private void InitializeDropdowns()
        {
            // Populate the Product dropdown
            foreach (var material in Data.CargoData.MaterialWeights.Keys)
            {
                cmbProduct.Items.Add(material);
            }

            // Set default selected index (optional)
            cmbProduct.SelectedIndex = 0;

            // Populate the Thickness dropdown based on the selected product
            UpdateThicknessDropdown();

            // Populate the Region dropdown
            foreach (var region in Data.CargoData.RegionWeightLimits.Keys)
            {
                cmbRegion.Items.Add(region);
            }

            // Set default selected index for Region (optional)
            cmbRegion.SelectedIndex = 0;
        }
        private void InitializeDataGridView()
        {
            // Define columns for the DataGridView
            dataGridViewCargo.Columns.Add("Region", "Region");
            dataGridViewCargo.Columns.Add("MaxWeight", "MaxWeight");
            dataGridViewCargo.Columns.Add("Product", "Product");
            dataGridViewCargo.Columns.Add("Thickness", "Thickness");
            dataGridViewCargo.Columns.Add("Width", "Width");
            dataGridViewCargo.Columns.Add("Length", "Length");
            dataGridViewCargo.Columns.Add("MaxLength", "MaxLength");
            dataGridViewCargo.Columns.Add("Quantity", "Quantity");
            dataGridViewCargo.Columns.Add("QuantityPerPallet", "QTY / PLT");
            dataGridViewCargo.Columns.Add("ExtraWidth", "ExtraWidth");
            dataGridViewCargo.Columns.Add("WeightPerSquareMeter", "Weight (Kg/m2)");
            dataGridViewCargo.Columns.Add("TotalVolume", "Total Volume (m3)");
            dataGridViewCargo.Columns.Add("TotalWeight", "Total Weight (KG)");

            // Set DataGridView properties
            dataGridViewCargo.Columns["Region"].Visible = false;
            dataGridViewCargo.Columns["MaxLength"].Visible = false;
            dataGridViewCargo.Columns["QuantityPerPallet"].Visible = false;
            dataGridViewCargo.Columns["ExtraWidth"].Visible = false;
            dataGridViewCargo.Columns["TotalWeight"].Visible = false;
            dataGridViewCargo.Columns["TotalVolume"].Visible = false;
            dataGridViewCargo.Columns["MaxLength"].Visible = false;
            dataGridViewCargo.Columns["WeightPerSquareMeter"].Visible = false;
            dataGridViewCargo.AutoGenerateColumns = false;
            dataGridViewCargo.AllowUserToAddRows = false;
        }



        private void UpdateThicknessDropdown()
        {
            // Clear previous items
            cmbThickness.Items.Clear();

            // Get the selected product
            string selectedProduct = cmbProduct.SelectedItem as string;

            // Populate the Thickness dropdown based on the selected product
            if (Data.CargoData.MaterialWeights.ContainsKey(selectedProduct))
            {
                foreach (var thickness in Data.CargoData.MaterialWeights[selectedProduct].ThicknessWeights.Keys)
                {
                    cmbThickness.Items.Add(thickness);
                }

                // Set default selected index (optional)
                cmbThickness.SelectedIndex = 0;

                // Update quantity based on thickness
                UpdateQuantity();
            }
        }

        private void UpdateQuantity()
        {
            // Get the selected thickness
            int selectedThickness = Convert.ToInt32(cmbThickness.SelectedItem);

            // Get the entered quantity from the TextBox
            if (!int.TryParse(txtQuantity.Text, out int selectedQuantity) || selectedQuantity <= 0)
            {
                // Display an error message if the input is not a valid positive integer
                lblWarning.Text = "Please enter a valid positive integer for the quantity.";
                return;
            }

            // Set the maximum quantity based on thickness
            int maxQuantity = (selectedThickness == 35) ? 28 : 21;

            // Display a warning if the entered quantity is not a multiple of the allowed quantity
            if (selectedQuantity % maxQuantity != 0)
            {
                lblWarning.Text = $"Warning: Quantity must be a multiple of {maxQuantity}.";
            }
            else
            {
                lblWarning.Text = ""; // Clear the warning if the quantity is valid
            }
        }

        private void cmbThickness_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update quantity when the selected thickness changes
            UpdateQuantity();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

        }

        private int GetMaxQuantityPerPallet()
        {
            // Get the selected thickness
            int selectedThickness = Convert.ToInt32(cmbThickness.SelectedItem);

            // Return the maximum quantity per pallet based on thickness
            return (selectedThickness == 35) ? 28 : 21;
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update Thickness dropdown when the selected product changes
            UpdateThicknessDropdown();
        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            // Get user input
            string selectedProduct = cmbProduct.SelectedItem.ToString();
            int selectedThickness = Convert.ToInt32(cmbThickness.SelectedItem);
            int selectedQuantity = Convert.ToInt32(txtQuantity.Text);
            int selectedWidth = Convert.ToInt32(numericUpDownWidth.Text);
            int selectedLength = Convert.ToInt32(numericUpDownLength.Text);

            // Create a new CargoItem
            CargoItem newCargoItem = new CargoItem
            {
                Product = selectedProduct,
                Thickness = selectedThickness,
                Quantity = selectedQuantity,
                Width = selectedWidth,
                Length = selectedLength
            };

            // Add the new CargoItem to the list
            CargoList.Add(newCargoItem);

            // Display the updated cargo list in the DataGridView
            DisplayCargoInDataGridView();
        }

        private void DisplayCargoInDataGridView()
        {
            // Clear the existing rows
            dataGridViewCargo.Rows.Clear();

            // Loop through the CargoList and add each item to the DataGridView
            foreach (var cargoItem in CargoList)
            {
                dataGridViewCargo.Rows.Add(
                    cargoItem.Region,
                    cargoItem.MaxWeight,
                    cargoItem.Product,
                    cargoItem.Thickness,
                    cargoItem.Width,
                    cargoItem.Length,
                    cargoItem.MaxLength,
                    cargoItem.Quantity,
                    cargoItem.QuantityPerPallet,
                    cargoItem.ExtraWidth,
                    cargoItem.WeightPerSquareMeter,
                    cargoItem.TotalVolume,
                    cargoItem.TotalWeight,
                    cargoItem.MaxWeightPerPallet
                );
            }
        }

        private void numericUpDownWidth_ValueChanged(object sender, EventArgs e)
        {
            // Example: Display a message if the width exceeds a certain threshold
            if (numericUpDownWidth.Value > 5000)
            {
                MessageBox.Show("Warning: The width is quite large. Are you sure?");
            }
        }

        private void numericUpDownLenght_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
