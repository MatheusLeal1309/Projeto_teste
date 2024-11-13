using System.Drawing;

namespace Projeto_teste
{
    public class Quadrado
    {
        public double[] Sides { get; set; }
        public double Area { get; set; }
        public double Perimeter { get; set; }

        public Quadrado(double side)
        {
            Sides = new double[4];
            for (int i = 0; i < 4; i++)
            {
                Sides[i] = side;
            }
        }

        public double getArea()
        {
            return Sides[0] * Sides[3];
        }

        public double getPerimetro()
        {
            return Sides[0] * 4;
        }
    }
}
