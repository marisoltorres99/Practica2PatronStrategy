namespace Practica2PatronStrategy.Service
{
    public class CalculadoraPago
    {
        private readonly IMetodoPagoStrategy _metodoPagoStrategy;

        public CalculadoraPago(IMetodoPagoStrategy metodoPagoStrategy)
        {
            _metodoPagoStrategy = metodoPagoStrategy;
        }

        public string ProcesarPago()
        {
            return _metodoPagoStrategy.ProcesarPago();
        }
    }
}
