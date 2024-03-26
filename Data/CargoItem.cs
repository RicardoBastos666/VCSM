using System;
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
                return Width + 10;
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
                    weightPerSquareMeter = 0; 
                }

                double totalArea = Width * Length * Quantity / 1_000_000.0; // Keep the dimensions in millimeters

                return totalArea * weightPerSquareMeter;
            }
        }
        public int NPFinal { get; set; }
    }
}