using System;

namespace logcopAngular
{
    public class Geomagnetism
    {
        public DateTime Date { get; set; }

        public int Magnetos { get; set; }

        public int ElectroUnits => 320 + (int)(Magnetos / 1.8);

        public string Summary { get; set; }
    }
}
