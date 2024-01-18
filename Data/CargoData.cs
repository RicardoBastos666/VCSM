using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSM.Data
{
    public class CargoData
    {
        public class MaterialProperties
        {
            public double WeightPerSquareMeter { get; set; }
            public Dictionary<int, double> ThicknessWeights { get; set; }
        }

        public static Dictionary<string, MaterialProperties> MaterialWeights { get; } = new Dictionary<string, MaterialProperties>
        {
            {"DoorFlushHoneyComb", new MaterialProperties { WeightPerSquareMeter = 9.5, ThicknessWeights = new Dictionary<int, double> { { 35, 9.5 }, { 44, 10.4 } } }},
            {"DoorFlushFR45_90", new MaterialProperties { WeightPerSquareMeter = 26.0, ThicknessWeights = new Dictionary<int, double> { { 44, 26.0 } } }},
            {"DoorFlushSolid", new MaterialProperties { WeightPerSquareMeter = 24.0, ThicknessWeights = new Dictionary<int, double> { { 35, 24.0 }, { 44, 26.0 } } }},
        };

        public static Dictionary<string, double> RegionWeightLimits { get; } = new Dictionary<string, double>
        {
            {"Florida", 26000},
            {"Texas", 23400},
            {"Illinois", 25500},
            {"Brooklyn", 23400},
            {"New Jersey", 23400},
            {"Virginia", 23400},
            {"Massachussets", 23500},
            {"Maryland", 23500},
            {"North Carolina", 25000},
            {"Pennsylvania", 25600},
        };
    }
}