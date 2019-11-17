using System;
using Newtonsoft.Json;

namespace com.b_velop.Slipways.GraphQL.Data.Dtos
{
    public class Measurement
    {
        /// <summary>
        /// Zeitpunkt codiert im ISO_8601 Format.
        /// </summary>
        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Wert als Dezimalzahl in der Einheit, welche durch die Timeseries der Station vorgegeben ist.
        /// </summary>
        [JsonProperty("value")]
        public double Value { get; set; }
    }
}
