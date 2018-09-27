using Microsoft.AspNetCore.Mvc;
using OrdenacaoDadosContrato.CONTRATO;
using System.Collections.Generic;

namespace OrdenacaoDadosAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Selection")]
    public class SelectionController : Controller
    {
        private readonly ISelectionSort _selectionSort;
        private readonly IConverterValores _Convert;
        private readonly IFiles _files;

        public SelectionController(ISelectionSort selectionSort, IConverterValores converterValores, IFiles files)
        {
            _selectionSort = selectionSort;
            _Convert = converterValores;
            _files = files;
        }

        [HttpPost]
        public void GenerateArchive([FromBody]string text)
        {
            _files.WriteFileAndConvertToByte( 
                _selectionSort.selectionSort(
                    _Convert.ConvertArrayToList(
                        _Convert.RemoveSinal(text).Split(" "))), "SelectionSort");
        }

        [HttpGet("SelectionSortDownload", Name = "SelectionSortDownload")]
        public IActionResult DownloadArchive()
        {
            string filePath = System.IO.Directory.GetCurrentDirectory() + "\\Files\\SelectionSort.txt";

            const string contentType = "text/plain";
            var result = new FileContentResult(System.IO.File.ReadAllBytes(filePath), contentType)
            {
                FileDownloadName = $"SelectionSort.txt"
            };

            return result;
        }
    }
}
