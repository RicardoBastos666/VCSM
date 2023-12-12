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
            {"DoorFlushHoneyComb", new MaterialProperties { WeightPerSquareMeter = 0.0, ThicknessWeights = new Dictionary<int, double> { { 35, 9.5 }, { 44, 10.4 } } }},
            {"DoorFlushFR45_90", new MaterialProperties { WeightPerSquareMeter = 26.0, ThicknessWeights = new Dictionary<int, double> { { 35, 26.0 }, { 44, 26.0 } } }},
            {"DoorFlushSolid", new MaterialProperties { WeightPerSquareMeter = 0.0, ThicknessWeights = new Dictionary<int, double> { { 35, 24.0 }, { 44, 26.0 } } }},
        };

        public static Dictionary<string, double> RegionWeightLimits { get; } = new Dictionary<string, double>
        {
            {"Region1", 10000.0},
            {"Region2", 20000.0},
            {"Region3", 30000.0},
            {"Region4", 40000.0},
            {"Region5", 50000.0},
            {"Region6", 60000.0},
            {"Region7", 70000.0},
            {"Region8", 80000.0},
            {"Region9", 90000.0},
            {"Region10", 100000.0},
        };
    }
}
