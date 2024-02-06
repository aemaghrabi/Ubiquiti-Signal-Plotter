using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubiquiti_Signal_Plotter
{
    public class IWConfig
    {
        [JsonProperty("signal")]
        public int Signal { get; set; }

        [JsonProperty("noise")]
        public int Noise { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }
}
