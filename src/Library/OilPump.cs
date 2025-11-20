namespace Ucu.Poo.Cars
{
    /// <summary>
    /// Representa una bomba de aceite.
    /// </summary>
    public class OilPump
    {
        /// <summary>
        /// El sensor de la bomba de aceite.
        /// </summary>
        public Sensor Sensor { get; private set; } = new Sensor();

        public bool FaultyOilPump()
        {
            if (this.Sensor.IsFaulty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}