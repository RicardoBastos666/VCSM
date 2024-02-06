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
        private int result;

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
            // Bind the btnRemove_Click event to the remove button
            btnRemove.Click += btnRemove_Click;
        }

        private void InitializeWidthNumericUpDown()
        {
            // NumericUpDown control numericUpDownWidth
            // Set the minimum and maximum values for the width
            numericUpDownLength.Minimum = 2032;  // Adjust this based on your minimum allowed length
            numericUpDownLength.Maximum = 2743;  // Remove or comment out this line to remove the maximum restriction
            numericUpDownWidth.Minimum = 300;
            numericUpDownWidth.Maximum = 1220;  // Remove or comment out this line to remove the maximum restriction

            // Set the default value or adjust the increment based on your requirements
            // numericUpDownWidth.Value = 0;  // Default value
            numericUpDownWidth.Increment = 1;  // Increment value

            // Optionally, handle the ValueChanged event to perform additional actions when the value changes
            // numericUpDownWidth.ValueChanged += numericUpDownLength_ValueChanged;
            // numericUpDownLength.ValueChanged += numericUpDownLength_ValueChanged;

            // Subscribe to the SelectedIndexChanged event of cmbProduct
            cmbProduct.SelectedIndexChanged += CmbProduct_SelectedIndexChanged;

            // Call the event handler manually to set the initial values
            CmbProduct_SelectedIndexChanged(cmbProduct, EventArgs.Empty);
        }

        private void CmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if the selected product is "DoorFlushFR45/90"
            if (cmbProduct.SelectedItem?.ToString() == "DoorFlushFR45_90")  
            {
                cmbThickness.SelectedIndex = 1; // Index 2 corresponds to the thickness 44
            }
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
            dataGridViewCargo.Columns.Add("NumberOfPallets", "Number of Pallets");
            //add efective lenght, width and pallet number

            // Set DataGridView properties
            dataGridViewCargo.Columns["Region"].Visible = false;
            dataGridViewCargo.Columns["MaxLength"].Visible = false;
            dataGridViewCargo.Columns["QuantityPerPallet"].Visible = false;
            dataGridViewCargo.Columns["ExtraWidth"].Visible = false;
            dataGridViewCargo.Columns["TotalVolume"].Visible = false;
            dataGridViewCargo.Columns["MaxLength"].Visible = false;
            dataGridViewCargo.Columns["WeightPerSquareMeter"].Visible = false;
            dataGridViewCargo.Columns["MaxWeight"].Visible = false;
            dataGridViewCargo.AutoGenerateColumns = false;
            dataGridViewCargo.AllowUserToAddRows = false;
        }

        private void UpdateThicknessDropdown()
        {
            cmbThickness.Items.Clear();

            string selectedProduct = cmbProduct.SelectedItem as string;

            if (Data.CargoData.MaterialWeights.ContainsKey(selectedProduct))
            {
                var thicknessWeights = Data.CargoData.MaterialWeights[selectedProduct];

                if (thicknessWeights != null)
                {
                    foreach (var thickness in thicknessWeights.Keys)
                    {
                        cmbThickness.Items.Add(thickness);
                    }
                }

                if (selectedProduct == "DoorFlushFR45_90")
                {
                    cmbThickness.Items.Clear();
                    cmbThickness.Items.Add(44);
                    cmbThickness.SelectedItem = 44;
                    cmbThickness.Enabled = false;
                }
                else
                {
                    cmbThickness.Enabled = true;
                }

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
            // If the selected product is "DoorFlush_FR45/90"
            if (cmbProduct.SelectedItem?.ToString() == "DoorFlushFR45_90")
            {
                // Check if the selected thickness is not 44
                if (cmbThickness.SelectedIndex != 1) // Index 1 corresponds to thickness 44
                {
                    // Display a warning in the existing lblWarning label
                    lblWarning.Text = "The 'DoorFlush_FR45/90' product only supports the thickness of 44.";

                    // Disable the "Add to Cargo" button
                    //btnAddToCargo.Enabled = false;
                    return; // Exit the method to prevent further processing
                }
                else
                {
                    // If thickness is 44, clear the warning in the existing lblWarning label
                    lblWarning.Text = "";
                }
            }
            else
            {
                // For other products, clear the warning in the existing lblWarning label
                lblWarning.Text = "";
            }

            // Clear the QTY field when thickness changes
            txtQuantity.Clear();
            // Update quantity when the selected thickness changes
            UpdateQuantity();

            // Enable or disable the "Add to Cargo" button based on the selected product and thickness
            //btnAddToCargo.Enabled = true;
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

            // Check if the selected product is "DoorFlush_FR45/90" and thickness is not 44
            if (selectedProduct == "DoorFlushFR45_90" && selectedThickness != 44)
            {
                lblWarning.Text = "DoorFlushFR45_90 does not have a thickness of 44. Please choose another thickness.";
                return; // Do not proceed with adding to cargo
            }

            // Check if the quantity is a multiple of 21 or 28
            int maxQuantityPerPallet = GetMaxQuantityPerPallet();
            if (selectedQuantity % maxQuantityPerPallet != 0)
            {
                lblWarning.Text = $"Warning: Quantity must be a multiple of {maxQuantityPerPallet}.";
                return; // Do not proceed with adding to cargo
            }

            // Calculate the total weight of all items in the CargoList
            double totalWeight = CargoList.Sum(item => item.TotalWeight);

            // Debug output
            Console.WriteLine($"TotalWeight before adding new item: {totalWeight}");

            // Get the maximum weight for the selected region
            string selectedRegion = cmbRegion.SelectedItem.ToString();
            double maxRegionWeight = Data.CargoData.RegionWeightLimits[selectedRegion];

            // Check if adding the new item will exceed the maximum weight for the region (removed selectedThickness, below)
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

            // Access the NumberOfPallets property
            int numberOfPallets = newCargoItem.NumberOfPallets;

            // Add the new CargoItem to the list
            CargoList.Add(newCargoItem);

            // Display the updated cargo list in the DataGridView
            DisplayCargoInDataGridView();

            // Clear all fields after adding to cargo
            ClearAllFields();
        }

        private double CalculateItemWeight(string product, int thickness, int quantity, int width, int length)
        {
            // material properties and dimensions to calculate the weight
            var thicknessWeights = Data.CargoData.MaterialWeights[product];

            // Default weightPerSquareMeter value
            double weightPerSquareMeter = 0.0;

            // Check if the selected thickness is available in the dictionary
            if (thicknessWeights.ContainsKey(thickness))
            {
                weightPerSquareMeter = thicknessWeights[thickness];
            }
            else
            {
                // Handle the case where the selected thickness is not found
                // maybe provide a default value or raise an exception based on your application's requirements
                Console.WriteLine($"Warning: Thickness {thickness} not found for product {product}. Using default thickness weight.");
                // For now, let's use 44 as a default thickness weight
                weightPerSquareMeter = thicknessWeights.ContainsKey(44) ? thicknessWeights[44] : 0.0;
            }

            double totalArea = width / 1000.0 * length / 1000.0 * quantity; // Convert width and length to meters

            double itemWeight = totalArea * weightPerSquareMeter;
            return itemWeight;
        }
        private void ClearAllFields()
        {
            cmbProduct.SelectedIndex = 0;
            cmbThickness.SelectedIndex = 0;
            txtQuantity.Clear();
            numericUpDownWidth.Value = 300;
            numericUpDownLength.Value = 2032;
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

                Console.WriteLine($"CargoItem: {cargoItem.Product}, Thickness: {cargoItem.Thickness}, NumberOfPallets: {cargoItem.NumberOfPallets}");


                // Declare totalArea here
                double totalArea = (cargoItem.Width / 1000.0) * (cargoItem.Length / 1000.0) * cargoItem.Quantity; // Convert width and length to meters
                
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
                    cargoItem.WeightPerLine,
                    cargoItem.NumberOfPallets
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

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (dataGridViewCargo.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridViewCargo.SelectedRows[0];

                // Get the values you need to identify the item (e.g., product, thickness, etc.)
                string selectedProduct = selectedRow.Cells["Product"].Value.ToString();
                int selectedThickness = Convert.ToInt32(selectedRow.Cells["Thickness"].Value);
                // Add more values as needed

                // Find the corresponding item in the CargoList
                CargoItem itemToRemove = CargoList.FirstOrDefault(item =>
                    item.Product == selectedProduct &&
                    item.Thickness == selectedThickness
                // Add more conditions as needed
                );

                // Remove the item from the CargoList
                CargoList.Remove(itemToRemove);

                // Update the DataGridView
                DisplayCargoInDataGridView();
            }
            else
            {
                MessageBox.Show("Please select a row to remove.");
            }
        }
    }
}
