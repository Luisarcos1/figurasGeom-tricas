using FiguraGeometrica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FiguraGeometrica
{
    class Cuadrado : Figura
{
        double lado1;

        public Cuadrado(double lado)
        {
            this.Lado1 = Lado1;
        }

        public override float area()
        {
            return Lado1 * Lado1;
        }

        public override float volumen()

        {
            return 0; // Los cuadrados no tienen volumen

        }
    }
}