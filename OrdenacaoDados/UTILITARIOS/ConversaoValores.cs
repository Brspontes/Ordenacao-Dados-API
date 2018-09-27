using OrdenacaoDadosContrato.CONTRATO;
using System.Collections.Generic;
using System.IO;

namespace OrdenacaoDados.UTILITARIOS
{
    public class ConversaoValores : IConverterValores, IFiles
    {
        public List<string> ConvertArrayToList(string[] array)
        {
            List<string> list = new List<string>();

            foreach (string valor in array)
            {
                list.Add(valor);
            }

            return list;
        }

        public string RemoveSinal(string texto)
        {
            texto = texto.Replace(".", "");
            texto = texto.Replace(",", "");
            texto = texto.Replace(":", "");
            texto = texto.Replace(";", "");
            texto = texto.Replace("|", "");
            texto = texto.Replace("/", "");
            texto = texto.Replace("-", " ");
            texto = texto.Replace("\\", " ");

            return texto;
        }

        public void WriteFileAndConvertToByte(List<string> list, string ordenacao)
        {
            File.WriteAllLines($@"..\OrdenacaoDadosAPI\Files\{ordenacao}.txt", list);
        }
    }
}
