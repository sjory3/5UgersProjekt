using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebWeatherApi.Models
{
    public class Place
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double CoordinatesN { get; set; }
        public double CoordinatesE { get; set; }
        public double Temperature { get; set; }
        public string Country { get; set; }
        public int SoilMoisture { get; set; }
    }
}