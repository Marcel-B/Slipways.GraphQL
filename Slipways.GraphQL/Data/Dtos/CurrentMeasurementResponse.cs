using System.Text.Json.Serialization;

namespace com.b_velop.Slipways.GraphQL.Data.Dtos
{
    public class CurrentMeasurementResponse
    {
        /// <summary>
        /// Kurzbezeichnung, maximal 40 Zeichen.
        /// </summary>
        [JsonPropertyName("shortname")]
        public string Shortname { get; set; }

        /// <summary>
        /// Langbezeichnung, maximal 255 Zeichen.
        /// </summary>
        [JsonPropertyName("longname")]
        public string Longname { get; set; }

        /// <summary>
        /// Maßeinheit.
        /// </summary>
        [JsonPropertyName("unit")]
        public string Unit { get; set; }

        /// <summary>
        /// Abstand der Messwerte in Minuten.
        /// </summary>
        [JsonPropertyName("equidistance")]
        public int Equidistance { get; set; }

        [JsonPropertyName("currentMeasurement")]
        public CurrentMeasurement CurrentMeasurement { get; set; }

        [JsonPropertyName("gaugeZero")]
        public GaugeZero GaugeZero { get; set; }
    }
}
