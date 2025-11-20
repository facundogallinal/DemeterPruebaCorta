using System.Collections.Generic;

namespace Ucu.Poo.Cars
{
    /// <summary>
    /// Representa el motor de un auto con una bomba de aceite y cuatro
    /// inyectores de combustible.
    /// </summary>
    public class Engine
    {
        /// <summary>
        /// La bomba de aceite del motor.
        /// </summary>
        public OilPump OilPump { get; private set; } = new OilPump();

        private FuelInjector[] fuelInjectors = new FuelInjector[4];

        /// <summary>
        /// Los inyectores de combustible del motor.
        /// </summary>
        public IReadOnlyList<FuelInjector> FuelInjectors { get { return this.fuelInjectors; } }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Engine"/>.
        /// </summary>
        public Engine()
        {
            for (int i = 0; i < 4; i++)
            {
                this.fuelInjectors[i] = new FuelInjector();
            }
        }
    }
}
