namespace Strategy.Impostos
{
    public class ICCC : IImposto
    {    
        public double CalcularImposto(double ValorOrcamento)
        {
            if (ValorOrcamento < 1000)
                return ValorOrcamento * 0.05;
            else if (ValorOrcamento <= 3000)
                return ValorOrcamento * 0.07;
            else
                return ValorOrcamento * 0.08 + 30;
        }
    }
}
