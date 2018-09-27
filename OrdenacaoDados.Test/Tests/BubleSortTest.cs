using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrdenacaoDados.ORDENACOES;

namespace OrdenacaoDados.Test
{
    [TestClass]
    public class BubleSortTest
    {
        [TestMethod]
        public void BubleSort()
        {
            var _bubleSort = new BubleSort();

            var list = _bubleSort.bubleSort(new System.Collections.Generic.List<string>
            {
                "Edilaine",
                "Brian",
                "Nicolas"
            });

            Assert.AreEqual(list[0], "Brian");
            Assert.AreEqual(list[1], "Edilaine");
            Assert.AreEqual(list[2], "Nicolas");
        }
    }
}
