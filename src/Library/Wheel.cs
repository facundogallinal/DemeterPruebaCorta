namespace Ucu.Poo.Cars
{
    /// <summary>
    /// Representa una rueda de un auto.
    /// </summary>
    public class Wheel
    {
        /// <summary>
        /// El freno de la rueda.
        /// </summary>
        public Break Break { get; private set; } = new Break();
    }

}