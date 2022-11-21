using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2.exercicio5
{
    internal class Motor
    {
        double cilindrda;

        public Motor(double cilindrda)
        {
            this.cilindrda = cilindrda;
        }

        public double Cilindrada { get { return cilindrda; } private set { } }
    }
}
