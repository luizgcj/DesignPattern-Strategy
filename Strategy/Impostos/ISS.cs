namespace Strategy.Impostos
{
    public class ISS : IImposto
    {
        private double _aliquota = 6.00;
        public double CalcularImposto(double VrOrcamento)
        {
            return (VrOrcamento * _aliquota / 100) + 50;
        }
    }
}
