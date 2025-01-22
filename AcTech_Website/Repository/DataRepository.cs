using Frank_Website.Models;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Frank_Website.Reporsitory
{
    public class DataRepository : IDataRepository
    {
        private readonly IWebHostEnvironment _env;

        public DataRepository(IWebHostEnvironment env)
        {
            _env = env;
        }

        public async Task<List<AboutUsDataModel>> GetDataAsync()
        {
            var filePath = Path.Combine(_env.WebRootPath, "Data", "About", "about-data.json");
            var jsonData = await File.ReadAllTextAsync(filePath);

            var data = JsonSerializer.Deserialize<List<AboutUsDataModel>>(jsonData);

            return data;
        }

        public async Task<List<CuisineDataModel>> GetCuisineDataAysync()
        {
            var filePath = Path.Combine(_env.WebRootPath, "Data", "Cuisine", "cuisine-data.json");
            var jsonData = await File.ReadAllTextAsync(filePath);

            var data = JsonSerializer.Deserialize<List<CuisineDataModel>>(jsonData);

            return data;
        }
    }
}
