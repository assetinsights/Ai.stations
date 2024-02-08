using Newtonsoft.Json;
using System.Collections.Generic;

namespace Ai.Stations.Models
{
    public class GeoModel
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("features")]
        public List<Feature> Features { get; set; }
    }

    public class Feature
    {
        [JsonProperty("geometry")]
        public Geometry Geometry { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("properties")]
        public Properties Properties { get; set; }
    }

    public class Geometry
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("coordinates")]
        public List<double> Coordinates { get; set; }
    }

    public class Properties
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("marker-symbol")]
        public string MarkerSymbol { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("lines")]
        public List<string> Lines { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }
    }
}
