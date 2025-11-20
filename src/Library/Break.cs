namespace Ucu.Poo.Cars
{
    /// <summary>
    /// Represents un freno de un auto.
    /// </summary>
    public class Break
    {
        /// <summary>
        /// El sensor del freno.
        /// </summary>
        public Sensor Sensor { get; private set; } = new Sensor();
    }
}
