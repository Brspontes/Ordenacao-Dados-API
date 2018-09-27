using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenacaoDadosContrato.CONTRATO
{
    public interface IFiles
    {
        //byte[] WriteFileAndConvertToByte(List<string> list, string ordenacao);
        void WriteFileAndConvertToByte(List<string> list, string ordenacao);
    }
}
