using System;
using System.Text.Json.Serialization;

namespace com.b_velop.Slipways.GraphQL.Data.Dtos
{
    public class Measurement
    {
        /// <summary>
        /// Zeitpunkt codiert im ISO_8601 Format.
        /// </summary>
        [JsonPropertyName("timestamp")]
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Wert als Dezimalzahl in der Einheit, welche durch die Timeseries der Station vorgegeben ist.
        /// </summary>
        [JsonPropertyName("value")]
        public double Value { get; set; }
    }
}
