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
        public double TotalWeight { get; set; }
        public double MaxWeightPerPallet { get; set; }
    }
}
