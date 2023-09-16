using Microsoft.AspNetCore.Mvc;

namespace MediumPartnerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediumPartnerController : ControllerBase
    {
        [HttpGet]
        public  async Task<IActionResult> GetAllPartners()
        {
            var mediumPartners = new List<Models.MediumPartner>
            {
                new Models.MediumPartner
                {
                    Id = 1,
                    Name = "TestUser",
                    FirstName = "Test",
                    LastName = "User",
                    Place = "New York City"
                }
            };

            return Ok(mediumPartners); 
        }
    }
}
