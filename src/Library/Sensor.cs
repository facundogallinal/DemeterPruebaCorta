namespace Ucu.Poo.Cars
{
    /// <summary>
    /// Representa un sensor de un componente del auto.
    /// </summary>
    public class Sensor
    {
        /// <summary>
        /// Obtiene un valor que indica si el sensor está fallando.
        /// </summary>
        public bool IsFaulty { get; private set;}

        /// <summary>
        /// Hace que el sensor falle.
        /// </summary>
        public void Fail()
        {
            this.IsFaulty = true;
        }
    }
}
