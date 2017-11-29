using System.Threading.Tasks;
using Carledger.Models;
using Carledger.Services;
using Microsoft.AspNetCore.Mvc;

namespace Carledger.Controllers
{
    public class MileageController : Controller
    {
        [HttpGet]
        [Route("/mileage/{carId}")]
        public IActionResult Index([FromRoute] string carId)
        {
            var transaction = new MileageTransaction {Asset = carId};
            return View(transaction);
        }
        
        [HttpPost]
        [Route("/mileage/{carId}")]
        public async Task<IActionResult> ExecuteTransaction([FromForm] string asset, [FromForm] string mileage)
        {
            var transaction = new MileageTransaction {Asset = asset, NewMileage = mileage, Class = "org.codeart.carledger.MileageTransaction", Timestamp = null, TransactionId = null};
            await CarledgerService.ExecuteMileageTransaction(transaction);
            return RedirectToAction("Index", "Car");
        }
    }
}