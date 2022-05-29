using Strategy.Entities;
using Strategy.Helpers;
using Strategy.Impostos;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            ICMS icms = new ICMS();
            ISS iss = new ISS();
            ICCC iccc = new ICCC();
            Orcamento orcamento = new Orcamento(3001);
            CalculadorImposto calculador = new CalculadorImposto(orcamento, iccc);
            calculador.Calcular();
      
        }
    }
}
