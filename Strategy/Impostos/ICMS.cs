namespace Strategy.Impostos
{
    public class ICMS : IImposto
    {
        private double _aliquota = 5.00;
        public double CalcularImposto(double VrOrcamento)
        {
            return (VrOrcamento * _aliquota / 100) + 50;
        }
    }
}
