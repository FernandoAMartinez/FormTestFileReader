using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormTestFileReader
{
    public class CreditCardFile
    {
        public DN151 Header { get; set; }
        public List<DN143> PaymentLots { get; set; }
    }

    public class DN151
    {
        public string CodEnt { get; set; }
        public string Sucursal { get; set; }
        public string RegLotes { get; set; }
        public string RegTransac { get; set; }
        public string ImporteTotal { get; set; }
    }

    public class DN143
    {
        public string CodRegistro { get; set; }
        public string Ordenamiento { get; set; }
        public string Plan { get; set; }
        public string Sucursal { get; set; }
        public string TipoCuenta { get; set; }
        public string Movimiento { get; set; }
        public string FechaProceso { get; set; }
        public string Periodo { get; set; }
        public string Vencimiento{ get; set; }
        public string Tarifa { get; set; }

        public List<DN144> Transacciones { get; set; }
    }

    public class DN144
    {
        public string CodRegistro { get; set; }
        public string Ordenamiento { get; set; }
        public string Sucursal { get; set; }
        public string Tarjeta { get; set; }
        public string Cliente { get; set; }
        public string Importe { get; set; }
        public string Motivo { get; set; }
        public string Tarifa { get; set; }
    }
}
