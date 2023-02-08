using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrecaoExerciciosFixacaoUm
{
    public class Retangulo
    {
        public double Largura, ALtura;

        public double Area()
        {
            return Largura * ALtura;
        }

        public double Perimentro()
        {
            return 2 * (ALtura + Largura);
        }
        public double Diagonal()
        {
            return Math.Sqrt(ALtura * ALtura + Largura * Largura);
        }
    }
}
