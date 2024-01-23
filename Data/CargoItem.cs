using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSM.Data
{
    public class CargoItem
    {
        public string Region { get; set; }
        public double MaxWeight { get; set; }
        public string Product { get; set; }
        public int Thickness { get; set; }
        public int Width { get; set; }
        public int Length { get; set; }
        public int MaxLength { get; set; }
        public int Quantity { get; set; }
        public int QuantityPerPallet { get; set; }
        public int ExtraWidth { get; set; }
        public double WeightPerSquareMeter { get; set; }
        public double TotalVolume { get; set; }
        //public double TotalWeight { get; set; }
        public double MaxWeightPerPallet { get; set; }
        public double WeightPerLine => Quantity * WeightPerSquareMeter * Width * Length / 1_000_000;  // Assuming the dimensions are in millimeters

        public double TotalWeight
        {
            get
            {
                // Calculate the total weight based on your logic
                double weightPerSquareMeter = Data.CargoData.MaterialWeights[Product].WeightPerSquareMeter;

                // Check if the specified thickness exists in the dictionary
                double thicknessWeight;
                if (Data.CargoData.MaterialWeights[Product].ThicknessWeights.ContainsKey(Thickness))
                {
                    thicknessWeight = Data.CargoData.MaterialWeights[Product].ThicknessWeights[Thickness];
                }
                else
                {
                    // Handle the case where the thickness is not found (you can use a default value or raise an error)
                    Console.WriteLine($"Warning: Thickness {Thickness} not found for product {Product}. Using default thickness weight.");
                    // You may want to provide a default value or raise an exception based on your application's requirements
                    thicknessWeight = 44;
                }

                double totalArea = Width * Length * Quantity / 1_000_000.0; // Keep the dimensions in millimeters

                return totalArea * weightPerSquareMeter + thicknessWeight * Quantity;
            }
        }


    }
}
