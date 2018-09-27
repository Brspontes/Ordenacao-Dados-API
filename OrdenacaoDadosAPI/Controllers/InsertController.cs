using Microsoft.AspNetCore.Mvc;
using OrdenacaoDadosContrato.CONTRATO;
using System.Collections.Generic;

namespace OrdenacaoDadosAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Insert")]
    public class InsertController : Controller
    {
        private readonly IInsertionSort _insertionSort;
        private readonly IConverterValores _Convert;
        private readonly IFiles _files;

        public InsertController(IInsertionSort insertionSort, IConverterValores converterValores, IFiles files)
        {
            _insertionSort = insertionSort;
            _Convert = converterValores;
            _files = files;
        }

        [HttpPost]
        public void GenerateArchive([FromBody]string text)
        {
            _files.WriteFileAndConvertToByte(
                   _insertionSort.insertionSort(
                       _Convert.ConvertArrayToList(
                           _Convert.RemoveSinal(text).Split(" "))), "InsertSort");
        }

        [HttpGet("InsertSortDownload", Name = "InsertSortDownload")]
        public IActionResult DownloadArchive()
        {
            string filePath = System.IO.Directory.GetCurrentDirectory() + "\\Files\\InsertSort.txt";

            const string contentType = "text/plain";
            var result = new FileContentResult(System.IO.File.ReadAllBytes(filePath), contentType)
            {
                FileDownloadName = $"InsertSort.txt"
            };

            return result;
        }
    }
}
