using Alura.DesignPatterns2.Cap5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.DesignPatterns2.Cap4
{
    class Soma : IExpressao
    {
        public IExpressao Esquerda { get; private set; }
        public IExpressao Direita { get; private set; }

        public Soma(IExpressao esquerda, IExpressao direita)
        {
            this.Esquerda = esquerda;
            this.Direita = direita;
        }

        public int Avalia()
        {
            return Esquerda.Avalia() + Direita.Avalia();
        }

        public void Aceita(IVisitor impressora)
        {
            impressora.ImprimeSoma(this);
        }
    }
}
