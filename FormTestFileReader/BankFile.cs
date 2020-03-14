using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormTestFileReader
{
    public class BankFile
    {
        public BankHeader Header { get; set; }

        public List<BankDetail> Details { get; set; }

        public BankTrailer Trailer { get; set; }
    }

    public class BankHeader
    {
        public string TipoRegistro {get; set;}
        public string NroPrestacion {get; set;}
        public string Servicio {get; set;}
        public string FechaGeneracion{get; set;}
        public string Identificacion{get; set;}
        public string Origen{get; set;}
        public string ImporteTotal { get; set; }
        public string CantRegistros { get; set; }
    }

    public class BankDetail
    {
        public string TipoRegistro { get; set; }
        public string Cliente { get; set; }
        public string Cbu { get; set; }
        public string Referencia{ get; set; }
        public string PrimerVencimiento { get; set; }
        public string ImportePrimerVencimiento{ get; set; }
        public string SegundoVencimiento { get; set; }
        public string ImporteSegundoVencimiento { get; set; }
        public string TercerVencimiento { get; set; }
        public string ImporteTercerVencimiento { get; set; }
        public string Moneda { get; set; }
        public string MotivoRechazo { get; set; }
    }

    public class BankTrailer
    {
        public string TipoRegistro { get; set; }
        public string NroPrestacion { get; set; }
        public string Servicio { get; set; }
        public string FechaGeneracion { get; set; }
        public string Identificacion { get; set; }
        public string Origen { get; set; }
        public string ImporteTotal { get; set; }
        public string CantRegistros { get; set; }
    }
}
