using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.DesignPatterns2.Cap4
{
    class Subtracao : IExpressao
    {
        private IExpressao esquerda;
        private IExpressao direita;

        public Subtracao(IExpressao esquerda, IExpressao direita)
        {
            this.esquerda = esquerda;
            this.direita = direita;
        }

        public int Avalia()
        {
            return this.esquerda.Avalia() - direita.Avalia();
        }
    }
}
