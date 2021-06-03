using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp6
{
    class Calculadora
    {
        public float num1, num2;

        public float suma(float num1, float num2)
        {
            return num1 + num2;
        }

        public float resta(float num1, float num2)
        {
            return num1 - num2;
        }
        public float mult(float num1, float num2)
        {
            return num1 * num2;
        }
        public float div(float num1,float num2)
        {
            return num1 / num2;
        }
    }
}
