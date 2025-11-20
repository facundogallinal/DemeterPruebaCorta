using System;
using System.Collections;
using System.Collections.Generic;

namespace Ucu.Poo.Cars
{
    /// <summary>
    /// Representa un auto con su motor y 4 ruedas.
    /// </summary>
    public class Car
    {
        /// <summary>
        /// Obtiene o establece la marca del auto.
        /// </summary>
        public string Make { get; set; }

        /// <summary>
        /// Obtiene o establece el modelo del auto.
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Obtiene o establece el año del auto.
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Obtiene el motor del auto.
        /// </summary>
        public Engine Engine { get; private set; }

        private Wheel[] wheels;

        /// <summary>
        /// Obtiene las ruedas del auto.
        /// </summary>
        public IReadOnlyList<Wheel> Wheels { get { return this.wheels; } }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Car"/>.
        /// </summary>
        /// <param name="make">El fabricante del auto.</param>
        /// <param name="model">El modelo del auto.</param>
        /// <param name="year">El año dle auto.</param>
        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
            this.Engine = new Engine();
            this.wheels = new Wheel[4];
            for (int i = 0; i < 4; i++)
            {
                this.wheels[i] = new Wheel();
            }
        }

        /// <summary>
        /// Devuelve una representación en text del auto.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Year} {Make} {Model}";
        }

        /// <summary>
        /// Determina la cantidad de sensores defectuosos en el auto.
        /// </summary>
        /// <returns>La cantidad de sensores defectuosos.</returns>
        public int CountFaultySensors()
        {
            int faultyCount = 0;

            for (int i = 0; i < 4; i++)
            {
                if (this.Engine.FuelInjectors[i].Sensor.IsFaulty)
                {
                    faultyCount++;
                }
            }

            for (int i = 0; i < 4; i++)
            {
                if (this.Wheels[i].Break.Sensor.IsFaulty)
                {
                    faultyCount++;
                }
            }

            if (this.Engine.OilPump.Sensor.IsFaulty)
            {
                faultyCount++;
            }

            return faultyCount;
        }
    }
}