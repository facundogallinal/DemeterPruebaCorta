//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;

namespace Ucu.Poo.Cars
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            Car car = new Car("Ferrari", "488 Spider", 2019);
            Console.WriteLine(car.ToString());
            Console.WriteLine("Número de sensores defectuosos: " + car.CountFaultySensors());
        }
    }
}