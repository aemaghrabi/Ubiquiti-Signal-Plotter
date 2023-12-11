using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Ubiquiti_Signal_Plotter
{
    public class WstalistResponse
    {
        [JsonProperty("mac")]
        public string MacAddress { get; set; }

        [JsonProperty("name")]
        public string DeviceName { get; set; }

        [JsonProperty("lastip")]
        public string LastIP { get; set; }

        [JsonProperty("tx")]
        public double TransmitPower { get; set; }

        [JsonProperty("rx")]
        public double ReceviedPower { get; set; }

        [JsonProperty("rssi")]
        public int RSSI { get; set; }

        [JsonProperty("signal")]
        public int Signal { get; set; }

        [JsonProperty("distance")]
        public int Distance { get; set; }

        [JsonProperty("noisefloor")]
        public int NoiseFloor { get; set; }

        [JsonProperty("remote")]
        public RemoteDevice Remote { get; set; }
    }

    public class RemoteDevice
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("hostname")]
        public string Hostname { get; set; }

        [JsonProperty("signal")]   
        public int Signal { get; set; }

        [JsonProperty("tx_power")]
        public decimal TransmitPower { get; set; }

        [JsonProperty("rssi")]
        public int RSSI { get; set; }
        
        [JsonProperty("noisefloor")]
        public int NoiseFloor { get; set; }

        [JsonProperty("distance")]
        public int Distance { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }
    }
}
