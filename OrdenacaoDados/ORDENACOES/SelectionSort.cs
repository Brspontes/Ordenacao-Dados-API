using OrdenacaoDadosContrato.CONTRATO;
using System.Collections.Generic;
using System.Diagnostics;

namespace OrdenacaoDados.ORDENACOES
{
    public class SelectionSort : ISelectionSort
    {
        public List<string> selectionSort(List<string> texto)
        {
            int min = 0;
            var aux = string.Empty;

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < (texto.Count - 1); i++)
            {
                min = i;
                for(int j = i + 1; j < texto.Count; j++)
                {
                    if(string.Compare(texto[min], texto[j]) > 0)
                    {
                        min = j;
                    }
                }
                if(i != min)
                {
                    aux = texto[min];
                    texto[min] = texto[i];
                    texto[i] = aux;
                }
            }
            stopwatch.Stop();

            texto.Add("Tempo de execucao: " + stopwatch.Elapsed.ToString());

            return texto;
        }
    }
}
