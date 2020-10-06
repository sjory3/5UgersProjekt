using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebWeatherApi.DataAccess;
using WebWeatherApi.Models;

namespace WebWeatherApi.Controllers
{
    [ApiController]
    [Route("api/place")]
    public class PlaceController : ControllerBase
    {
        private readonly ILogger<PlaceController> _logger;
        private DataContext dataContext;

        public PlaceController(ILogger<PlaceController> logger)
        {
            _logger = logger;
            dataContext = new DataContext();
        }

        [HttpGet("{id}")]
        public Place Get(int id)
        {           
            return dataContext.GetPlace(id);
        }

        [HttpGet]
        public List<Place> GetAll()
        {
            return dataContext.GetAllPlaces();
        }
    }
}

