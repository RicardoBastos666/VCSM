using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VCSM.Data
{
    public class CargoItem
    {
        public string Region { get; set; }
        public double MaxWeight { get; set; }
        public string Product { get; set; }
        public int Thickness { get; set; }
        public int Width { get; set; }
        public int EffWidth
        { 
            get
            {
                //calc EffWidth based on documentation logic 
                if (Width < 2299)
                {
                    return Width + 10;
                }
                else 
                {
                    return Width + 40;
                }
            } 
        }
        public int Length { get; set; }
        public int EffLength => Length + 20;
        public int MaxLength { get; set; }
        public int Quantity { get; set; }
        public int QuantityPerPallet { get; set; }
        public double WeightPerSquareMeter { get; set; }
        public double TotalVolume { get; set; }
        public double MaxWeightPerPallet { get; set; }

        public int NumberOfPallets
        {
            get
            {
                // Return the number of pallets based on the thickness and quantity
                if (Thickness == 35)
                {
                    return Quantity / 28;
                }
                else if (Thickness == 44)
                {
                    return Quantity / 21;
                }
                else
                {
                    // Handle other thickness values (return 0 or show a warning)
                    MessageBox.Show($"An error ocurred. Thickness value of {Thickness} is invalid");
                    return 0;
                }
            }
        }

        public double WeightPerLine => Quantity * WeightPerSquareMeter * Width * Length / 1_000_000;  // Assuming the dimensions are in millimeters

        public double TotalWeight
        {
            get
            {
                // Calculate the total weight based on your logic
                double weightPerSquareMeter;

                if (Data.CargoData.MaterialWeights.ContainsKey(Product) &&
                    Data.CargoData.MaterialWeights[Product].ContainsKey(Thickness))
                {
                    weightPerSquareMeter = Data.CargoData.MaterialWeights[Product][Thickness];
                }
                else
                {
                    // Handle the case where the product or thickness is not found
                    Console.WriteLine($"Warning: Product {Product} with thickness {Thickness} not found. Using default weight.");
                    // You may want to provide a default value or raise an exception based on your application's requirements
                    weightPerSquareMeter = 0; // Set a default value, replace this with your logic
                }

                double totalArea = Width * Length * Quantity / 1_000_000.0; // Keep the dimensions in millimeters

                return totalArea * weightPerSquareMeter;
            }
        }
    }
}
