using Newtonsoft.Json;

namespace com.b_velop.Slipways.GraphQL.Data.Dtos
{
    public class CurrentMeasurementResponse
    {
        /// <summary>
        /// Kurzbezeichnung, maximal 40 Zeichen.
        /// </summary>
        [JsonProperty("shortname")]
        public string Shortname { get; set; }

        /// <summary>
        /// Langbezeichnung, maximal 255 Zeichen.
        /// </summary>
        [JsonProperty("longname")]
        public string Longname { get; set; }

        /// <summary>
        /// Maßeinheit.
        /// </summary>
        [JsonProperty("unit")]
        public string Unit { get; set; }

        /// <summary>
        /// Abstand der Messwerte in Minuten.
        /// </summary>
        [JsonProperty("equidistance")]
        public int Equidistance { get; set; }

        [JsonProperty("currentMeasurement")]
        public CurrentMeasurement CurrentMeasurement { get; set; }

        [JsonProperty("gaugeZero")]
        public GaugeZero GaugeZero { get; set; }
    }
}
