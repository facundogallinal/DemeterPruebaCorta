using System.Collections.Generic;

namespace Ucu.Poo.Cars
{
    /// <summary>
    /// Representa un inyector de combustible.
    /// </summary>
    public class FuelInjector
    {
        /// <summary>
        /// El sensor del inyector de combustible.
        /// </summary>
        public Sensor Sensor { get; private set; } = new Sensor();
    }
}