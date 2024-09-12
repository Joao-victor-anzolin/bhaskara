using System.Security.Cryptography.X509Certificates;

namespace Bhaskara
{
    public class CalculadoraBhaskara
    {
        public static double [] CalcularRaiz(double a, double b, double c){
            double Delta = (b * b) - 4 * (a * c);

            if (Delta <= 0) {
                throw new ArgumentOutOfRangeException(
                    "Impossível resolver raíz"
                    );
            }

            double raiz1 = ((b * -1) - Math.Sqrt(Delta)) / 2 * a;
            double raiz2 = ((b * -1) + Math.Sqrt(Delta)) / 2 * a;

            return new double[] { raiz1, raiz2 } ;
        }

    }
}
