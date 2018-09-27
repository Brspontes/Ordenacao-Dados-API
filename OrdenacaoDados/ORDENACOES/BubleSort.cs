using OrdenacaoDadosContrato.CONTRATO;
using System.Collections.Generic;
using System.Diagnostics;

namespace OrdenacaoDados.ORDENACOES
{
    public class BubleSort : IBubleSort
    {
        public List<string> bubleSort(List<string> texto)
        {
            var temp = string.Empty;

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int x = 0; x < texto.Count; x++)
            {
                for(int y = (x + 1); y < texto.Count; y++)
                {
                    if (string.Compare(texto[x], texto[y]) > 0)
                    {
                        temp = texto[x];
                        texto[x] = texto[y];
                        texto[y] = temp;
                    }
                }
            }

            texto.Add("Tempo de execucao: " + stopwatch.Elapsed.ToString());

            return texto;
        }
    }
}
