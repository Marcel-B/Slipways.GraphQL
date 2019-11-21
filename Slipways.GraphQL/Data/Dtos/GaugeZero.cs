using System;
using System.Text.Json.Serialization;

namespace com.b_velop.Slipways.GraphQL.Data.Dtos
{
    public class GaugeZero
    {
        /// <summary>
        /// Einheit des Pegelnullpunkts (immer in Metern über einem Normalhöhennull)
        /// </summary>
        [JsonPropertyName("unit")]
        public string Unit { get; set; }

        /// <summary>
        /// Höhe als Dezimalwert
        /// </summary>
        [JsonPropertyName("value")]
        public double Value { get; set; }

        /// <summary>
        /// Beginn der Gültigkeit. ISO_8601 Datum.
        /// </summary>
        [JsonPropertyName("validFrom")]
        public DateTime ValidFrom { get; set; }
    }
}
