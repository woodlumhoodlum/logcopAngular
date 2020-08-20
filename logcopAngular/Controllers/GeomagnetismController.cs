using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace logcopAngular.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GeomagnetismController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Super Magnetic", "Very Magnetic", "Variable Magnetic Storm", "Mild Magnetism not too bad", "Lack of Magnetism", "Magnetic Drought", "Scorchingly Magnetic", "Wood Basically"
        };

        private readonly ILogger<GeomagnetismController> _logger;

        public GeomagnetismController(ILogger<GeomagnetismController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Geomagnetism> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 15).Select(index => new Geomagnetism
            {
                Date = DateTime.Now.AddDays(index),
                Magnetos = rng.Next(-20000, 60000),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
