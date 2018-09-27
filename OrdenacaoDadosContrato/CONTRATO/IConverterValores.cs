using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenacaoDadosContrato.CONTRATO
{
    public interface IConverterValores
    {
        List<string> ConvertArrayToList(string[] array);
        string RemoveSinal(string texto);
    }
}
