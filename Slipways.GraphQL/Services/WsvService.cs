﻿using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using com.b_velop.Slipways.GraphQL.Data.Dtos;
using Microsoft.Extensions.Logging;

namespace com.b_velop.Slipways.GraphQL.Services
{
    public class WsvService : IWsvService
    {
        private readonly HttpClient _client;
        private readonly ILogger<WsvService> _logger;
        public WsvService(
            HttpClient client,
            ILogger<WsvService> logger)
        {
            _client = client;
            _logger = logger;
        }

        public async Task<CurrentMeasurementResponse> GetAsync()
        {
            var response = await _client.GetAsync("/webservices/rest-api/v2/stations/KETZIN/W.json?includeCurrentMeasurement=true");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStreamAsync();
                var result = await JsonSerializer.DeserializeAsync<CurrentMeasurementResponse>(content);

                return result;
            }
            _logger.LogError($"Error while deserialize object");
            return null;
        }
    }
}
