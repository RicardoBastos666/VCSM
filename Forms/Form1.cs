using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using VCSM.Data;

namespace VCSM
{
    public partial class Form1 : Form
    {
        private List<CargoItem> CargoList = new List<CargoItem>();
        private bool userInteractedWithQuantity = false;
        public Form1()
        {
            InitializeComponent();
            InitializeDropdowns();
            InitializeDataGridView();
            InitializeWidthNumericUpDown();
            this.Size = new Size(1280, 720); // Set the form size to 1280x720

            // Prevent resizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            // Set the initial state of the warning label
            lblWarning.Text = "";
            // Hook up TextChanged event for txtQuantity
            txtQuantity.TextChanged += (sender, e) => UpdateQuantity();
        }

        private void InitializeWidthNumericUpDown()
        {
            // NumericUpDown control numericUpDownWidth
            // Set the minimum and maximum values for the width
            numericUpDownLength.Minimum = 0;  // Adjust this based on your minimum allowed length
            numericUpDownLength.Maximum = 9999;  // Remove or comment out this line to remove the maximum restriction
            numericUpDownWidth.Minimum = 0;
            numericUpDownWidth.Maximum = 9999;  // Remove or comment out this line to remove the maximum restriction
            // Set the default value or adjust the increment based on your requirements
            // numericUpDownWidth.Value = 0;  // Default value
            numericUpDownWidth.Increment = 1;  // Increment value
                                               // Optionally, handle the ValueChanged event to perform additional actions when the value changes
                                               // numericUpDownWidth.ValueChanged += numericUpDownLength_ValueChanged;
                                               // numericUpDownLength.ValueChanged += numericUpDownLength_ValueChanged;
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

            cmbThickness.SelectedIndexChanged += CmbThickness_SelectedIndexChanged;

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
            //add efective lenght, width and pallet number

            // Set DataGridView properties
            dataGridViewCargo.Columns["Region"].Visible = false;
            dataGridViewCargo.Columns["MaxLength"].Visible = false;
            dataGridViewCargo.Columns["QuantityPerPallet"].Visible = false;
            dataGridViewCargo.Columns["ExtraWidth"].Visible = false;
            dataGridViewCargo.Columns["TotalWeight"].Visible = true;
            dataGridViewCargo.Columns["TotalVolume"].Visible = false;
            dataGridViewCargo.Columns["MaxLength"].Visible = false;
            dataGridViewCargo.Columns["WeightPerSquareMeter"].Visible = false;
            dataGridViewCargo.Columns["MaxWeight"].Visible = false;
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
                //cmbThickness.SelectedIndex = 0;

                // Update quantity based on thickness
                UpdateQuantity();
            }
        }

        private void UpdateQuantity()
        {
            // Get the selected thickness
            int selectedThickness = Convert.ToInt32(cmbThickness.SelectedItem);

            // Get the entered quantity from the TextBox
            if (!int.TryParse(txtQuantity.Text, out int selectedQuantity))
            {
                lblWarning.Text = ""; // Clear any previous warnings
                return;
            }

            // Set the maximum quantity per pallet based on thickness
            int maxQuantityPerPallet = GetMaxQuantityPerPallet();

            // Display a warning if the entered quantity is not a multiple of the allowed quantity per pallet
            if (selectedQuantity <= 0 || selectedQuantity % maxQuantityPerPallet != 0)
            {
                lblWarning.Text = $"Warning: Quantity must be a positive multiple of {maxQuantityPerPallet}.";
                lblWarning.ForeColor = Color.Red; // Set the text color to red
            }
            else
            {
                lblWarning.Text = ""; // Clear the warning if the quantity is valid
            }
        }


        private int GetMaxQuantityPerPallet()
        {
            // Get the selected thickness
            int selectedThickness = Convert.ToInt32(cmbThickness.SelectedItem);

            // Return the maximum quantity per pallet based on thickness
            return (selectedThickness == 35) ? 28 : 21;
        }

        private void CmbThickness_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear the QTY field when thickness changes
            txtQuantity.Clear();
            // Update quantity when the selected thickness changes
            UpdateQuantity();
        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrEmpty(cmbProduct.Text) ||
                string.IsNullOrEmpty(cmbThickness.Text) ||
                string.IsNullOrEmpty(txtQuantity.Text) ||
                string.IsNullOrEmpty(numericUpDownWidth.Text) ||
                string.IsNullOrEmpty(numericUpDownLength.Text))
            {
                lblWarning.Text = "Please fill in all required fields.";
                return;
            }

            // Get user input
            string selectedProduct = cmbProduct.SelectedItem.ToString();
            int selectedThickness = Convert.ToInt32(cmbThickness.SelectedItem);
            int selectedQuantity = Convert.ToInt32(txtQuantity.Text);
            int selectedWidth = Convert.ToInt32(numericUpDownWidth.Text);
            int selectedLength = Convert.ToInt32(numericUpDownLength.Text);

            // Check if the quantity is a multiple of 21 or 28
            int maxQuantityPerPallet = GetMaxQuantityPerPallet();
            if (selectedQuantity % maxQuantityPerPallet != 0)
            {
                lblWarning.Text = $"Warning: Quantity must be a multiple of {maxQuantityPerPallet}.";
                return; // Do not proceed with adding to cargo
            }

            // Calculate the total weight of all items in the CargoList
            double totalWeight = CargoList.Sum(item => item.TotalWeight);

            // Get the maximum weight for the selected region
            string selectedRegion = cmbRegion.SelectedItem.ToString();
            double maxRegionWeight = Data.CargoData.RegionWeightLimits[selectedRegion];

            // Check if adding the new item will exceed the maximum weight for the region
            if (totalWeight + CalculateItemWeight(selectedProduct, selectedThickness, selectedQuantity, selectedWidth, selectedLength) > maxRegionWeight)
            {
                lblWarning.Text = $"Warning: Adding this item will exceed the maximum weight limit for the region ({maxRegionWeight} kg).";
                return; // Do not proceed with adding to cargo
            }

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

            // Clear all fields after adding to cargo
            ClearAllFields();
        }


        // method to calculate the weight of a single item
        private double CalculateItemWeight(string product, int thickness, int quantity, int width, int length)
        {
            // material properties and dimensions to calculate the weight
            double weightPerSquareMeter = Data.CargoData.MaterialWeights[product].WeightPerSquareMeter;
            double thicknessWeight = Data.CargoData.MaterialWeights[product].ThicknessWeights[thickness];
            double totalArea = (width / 100.0) * (length / 100.0) * quantity; // Convert width and length to meters
            double itemWeight = totalArea * weightPerSquareMeter + thicknessWeight * quantity;
            return itemWeight;
        }


        private void ClearAllFields()
        {
            cmbProduct.SelectedIndex = 0;
            cmbThickness.SelectedIndex = 0;
            txtQuantity.Clear();
            numericUpDownWidth.Value = 0;
            numericUpDownLength.Value = 0;
            // Add more fields to clear as needed
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update Thickness dropdown when the selected product changes
            UpdateThicknessDropdown();
        }

        private void DisplayCargoInDataGridView()
        {
            // Clear the existing rows
            dataGridViewCargo.Rows.Clear();

            double totalWeight = 0;

            // Loop through the CargoList and add each item to the DataGridView
            foreach (var cargoItem in CargoList)
            {
                totalWeight += cargoItem.TotalWeight;

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
                    cargoItem.MaxWeightPerPallet,
                    cargoItem.WeightPerLine
                );
            }

            // Update the total weight label
            lblTotalWeight.Text = $"Total container weight: {totalWeight} KG";
        }

        private void numericUpDownLength_ValueChanged(object sender, EventArgs e)
        {
            //Display a message if the width exceeds a certain threshold
            /*
            if (numericUpDownWidth.Value > numericUpDownLength.Value)
            {
                MessageBox.Show("Warning: The width is quite large. Are you sure?");
            }
            */
        }

        private void numericUpDownLenght_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
