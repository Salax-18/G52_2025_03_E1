using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Package2D
{
    [Serializable]

    public class Punto2D
    {
        public double x;
        public double y;


        public Punto2D()
        {
        }
        public Punto2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public double Distancia(Punto2D otroPunto)
        {
            return Math.Sqrt(Math.Pow(otroPunto.X - this.X, 2) + Math.Pow(otroPunto.Y - this.Y, 2));
        }
    }
}
