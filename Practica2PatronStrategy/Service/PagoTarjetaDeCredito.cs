namespace Practica2PatronStrategy.Service
{
    public class PagoTarjetaDeCredito : IMetodoPagoStrategy
    {
        public string ProcesarPago()
        {
            return "Usted pago con tarjeta de credito";
        }
    }
}
