using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrdenacaoDados.ORDENACOES;

namespace OrdenacaoDados.Test.Tests
{
    [TestClass]
    public class InsertionSortTest
    {
        [TestMethod]
        public void InsertionSort()
        {
            var retorno = new InsertionSort().insertionSort(new System.Collections.Generic.List<string>
            {
                "Edilaine",
                "Nicolas",
                "Brian"
            });

            Assert.AreEqual(retorno[0], "Brian");
            Assert.AreEqual(retorno[1], "Edilaine");
            Assert.AreEqual(retorno[2], "Nicolas");
        }
    }
}
