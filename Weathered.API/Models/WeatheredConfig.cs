﻿using System.Collections.Generic;

namespace Weathered.API.Models
{
    public class WeatheredConfig
    {
        /// <summary>
        /// Weather Station MAC Address. Found Here: https://ambientweather.net/devices
        /// </summary>
        public string MacAddress { get; set; }
        
        /// <summary>
        /// Ambient Weather API Key. Found Here: https://ambientweather.net/account
        /// </summary>
        public List<string> ApiKey { get; set; }
        
        /// <summary>
        /// Account Application Key. Found Here: https://ambientweather.net/account
        /// </summary>
        public string ApplicationKey { get; set; }
    }
}