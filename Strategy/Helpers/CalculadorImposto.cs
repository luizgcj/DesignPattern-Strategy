using Strategy.Entities;
using System;

namespace Strategy.Helpers
{
    public class CalculadorImposto
    {
        private Orcamento _orcamento;
        private IImposto _imposto;
        public CalculadorImposto (Orcamento orcamento, IImposto imposto)
        {
            _orcamento = orcamento;
            _imposto = imposto;
        }

        public void Calcular()
        {
            Console.WriteLine(_imposto.CalcularImposto(_orcamento.Valor));
        }
    }
}
