namespace Practica2PatronStrategy.Service
{
    public class PagoBilleteraVirtual : IMetodoPagoStrategy
    {
        public string ProcesarPago()
        {
            return "Usted pago con billetera virtual";
        }
    }
}
