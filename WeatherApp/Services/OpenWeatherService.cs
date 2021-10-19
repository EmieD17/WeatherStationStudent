﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Models;

namespace WeatherApp.Services
{
    public class OpenWeatherService : IWindDataService
    {
        public async Task<WindDataModel> GetDataAsync()
        {
            WindDataModel windDataModel = new WindDataModel();
            return windDataModel;
        }
    }
}
