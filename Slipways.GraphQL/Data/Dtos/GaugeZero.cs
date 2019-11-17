using System;
using Newtonsoft.Json;

namespace com.b_velop.Slipways.GraphQL.Data.Dtos
{
    public class GaugeZero
    {
        /// <summary>
        /// Einheit des Pegelnullpunkts (immer in Metern über einem Normalhöhennull)
        /// </summary>
        [JsonProperty("unit")]
        public string Unit { get; set; }

        /// <summary>
        /// Höhe als Dezimalwert
        /// </summary>
        [JsonProperty("value")]
        public double Value { get; set; }

        /// <summary>
        /// Beginn der Gültigkeit. ISO_8601 Datum.
        /// </summary>
        [JsonProperty("validFrom")]
        public DateTime ValidFrom { get; set; }
    }
}
