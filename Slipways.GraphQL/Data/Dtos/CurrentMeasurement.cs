using System;
using System.Text.Json.Serialization;

namespace com.b_velop.Slipways.GraphQL.Data.Dtos
{
    public class CurrentMeasurement
    {
        /// <summary>
        /// Zeitpunkt codiert im ISO_8601 Format.
        /// </summary>
        [JsonPropertyName("timestamp")]
        public DateTime Timestamp { get; set; }

        /// <summary>
        ///Wert als Dezimalzahl in der Einheit, welche durch die Timeseries der Station vorgegeben ist.
        /// </summary>
        [JsonPropertyName("value")]
        public double Value { get; set; }

        /// <summary>
        /// Drückt numerisch aus, ob es sich um steigende (1), fallende (-1) oder gleichbleibende (0) Tendenz handelt. Kann die Tendenz nicht ermittelt werden, so ist trend -999.
        /// </summary>
        [JsonPropertyName("trend")]
        public int Trend { get; set; }

        /// <summary>
        /// Diese Attribute sind nur bei Wasserständen vorhanden. Sie setzen den aktuellen Wasserstand entweder mit den mittleren niedrigsten Werten (MNW) und den mittleren höchsten Werten (MHW) in Beziehung (stateMnwMhw) oder mit dem höchsten Schifffahrtswasserstand (stateNswHsw). Die Attribute stateMnwMhw und stateNswHsw können folgende Werte annehmen:
        //       low: Aktueller Wasserstand unterhalb/gleich des MNW(nur stateMnwMhw)
        // normal: Aktueller Wasserstand zwischen MNW und MHW bzw.zwischen 0 und HSW
        // high: Aktueller Wasserstand oberhalb/gleich MHW bzw.HSW
        // unknown: Unbekannt, da MHW/MNW bzw.HSW für Zeitreihe nicht vorhanden
        // commented: Fehlfunktion oder Störung.Siehe Subressource comment in Ressource Timeseries
        // out-dated: Aktueller Wasserstand veraltet (älter als 25 Stunden)
        // Siehe auch die Hilfe zu den Grenzwerten.
        /// </summary>
        [JsonPropertyName("stateMnwMhw")]
        public string StateMnwMhw { get; set; }

        [JsonPropertyName("stateNswHsw")]
        public string StateNswHsw { get; set; }
    }
}
