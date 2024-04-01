using Microsoft.AspNetCore.Mvc;
using BidBay.API.UseCase.Auction.GetCurrent;

namespace BidBay.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuctionController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCurrentAuction()
        {
            var useCase = new GetCurrentAuctionUseCase();

            var result = useCase.Execute();

            return Ok(result);
        }
    }
}
