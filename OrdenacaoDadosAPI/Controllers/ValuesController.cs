using Microsoft.AspNetCore.Mvc;
using OrdenacaoDadosContrato.CONTRATO;

namespace OrdenacaoDadosAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Values")]
    public class ValuesController : Controller
    {
        private readonly IBubleSort _bubleSort;
        private readonly IConverterValores _Convert;
        private readonly IFiles _files;

        public ValuesController
            (
                IBubleSort bubleSort,
                IConverterValores converterValores,
                IFiles files
            )
        {
            _bubleSort = bubleSort;
            _Convert = converterValores;
            _files = files;
        }
    
        // GET api/values/5
        [HttpPost]
        public void GenerateArchive([FromBody]string text)
        {
             _files.WriteFileAndConvertToByte(
                _bubleSort.bubleSort(
                    _Convert.ConvertArrayToList(
                        _Convert.RemoveSinal(text).Split(" "))), "BubleSort");
        }

        [HttpGet("BubleSortDownload", Name = "BubleSortDownload")]
        public IActionResult DownloadArchive()
        {
            string filePath = System.IO.Directory.GetCurrentDirectory() + "\\Files\\BubleSort.txt";

            const string contentType = "text/plain";
            var result = new FileContentResult(System.IO.File.ReadAllBytes(filePath), contentType)
            {
                FileDownloadName = $"BubleSort.txt"
            };

            return result;
        }
    }
}
