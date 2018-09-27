using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrdenacaoDados.ORDENACOES;

namespace OrdenacaoDados.Test
{
    [TestClass]
    public class SelectionSortTest
    {
        [TestMethod]
        public void SelectionSort()
        {
            var selection = new SelectionSort();

            var retorno = selection.selectionSort(new System.Collections.Generic.List<string>
            {
                "Nicolas",
                "Edilaine",
                "Brian"
            });

            Assert.AreEqual(retorno[0], "Brian");
            Assert.AreEqual(retorno[1], "Edilaine");
            Assert.AreEqual(retorno[2], "Nicolas");
        }
    }
}
