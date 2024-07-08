using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitmapCacheTest.Model
{
    public class SampleMetric
    {
        public string Name { get; set; }
        public string AdditionalData { get; set; }
        public List<DataPoint> Points { get; set; } = new List<DataPoint>();
    }
}
