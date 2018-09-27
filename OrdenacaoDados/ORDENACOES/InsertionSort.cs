using OrdenacaoDadosContrato.CONTRATO;
using System.Collections.Generic;
using System.Diagnostics;

namespace OrdenacaoDados.ORDENACOES
{
    public class InsertionSort : IInsertionSort
    {
        public List<string> insertionSort(List<string> texto)
        {
            var temp = string.Empty;
            var y = 0;

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int x = 1; x < texto.Count; x++)
            {
                temp = texto[x];
                y = x - 1;

                while(y >= 0 && string.Compare(texto[y], temp) > 0)
                {
                    texto[y + 1] = texto[y];
                    y = y - 1;
                }
                texto[y + 1] = temp;
            }

            texto.Add("Tempo de execucao: " + stopwatch.Elapsed.ToString());

            return texto;
        }
    }
}
