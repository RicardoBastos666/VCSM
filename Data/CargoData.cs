using System.Collections.Generic;


namespace VCSM.Data
{
    public class CargoData
    {
        public class MaterialProperties
        {
            public double WeightPerSquareMeter { get; set; }
            public Dictionary<int, double> ThicknessWeights { get; set; }
        }

        public static Dictionary<string, Dictionary<int, double>> MaterialWeights { get; } = new Dictionary<string, Dictionary<int, double>>
        {
            {"DoorFlushHoneyComb", new Dictionary<int, double> { { 35, 9.5 }, { 44, 10.4 } }},
            {"DoorFlushFR45_90", new Dictionary<int, double> { { 44, 26.0 } }},
            {"DoorFlushSolid", new Dictionary<int, double> { { 35, 24.0 }, { 44, 26.0 } }},
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