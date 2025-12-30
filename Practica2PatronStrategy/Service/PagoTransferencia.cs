namespace Practica2PatronStrategy.Service
{
    public class PagoTransferencia : IMetodoPagoStrategy
    {
        public string ProcesarPago()
        {
            return "Usted pago con transferencia";

        }
    }
}
