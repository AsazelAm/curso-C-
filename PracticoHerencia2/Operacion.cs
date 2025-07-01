using System;

namespace PracticoHerencia2
{
    class Operacion
    {
        private double n1;
        private double n2;
        protected double res;
        private char operacion;

        public Operacion(double n1, double n2, double res, char operacion)
        {
            this.n1 = n1;
            this.n2 = n2;
            this.res = res;
            this.operacion = operacion;
        }

        public void mostrarResulatado()
        {
            Console.WriteLine($"la division es:");
        }
    }

    class Division : Operacion
    {
        private double division = 0;

        public double DIVISION
        {
            get { return division; }
            set { division = value; }
        }

        public Division(double n1, double n2, double res, char operacion, double division) : base(n1, n2, res, '/')
        {
            //DIVISION = n1 / n2;
            //res = DIVISION;
            division = n1 / n2;
            DIVISION = division;
        }


    }
}
