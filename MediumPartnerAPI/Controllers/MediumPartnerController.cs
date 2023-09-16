using MediumPartnerAPI.Services.PartnerService;
using Microsoft.AspNetCore.Mvc;

namespace MediumPartnerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediumPartnerController : ControllerBase
    {
        private readonly IMediumPartnerService _mediumPartnerService;
        public MediumPartnerController(IMediumPartnerService mediumPartnerService)
        {
            _mediumPartnerService = mediumPartnerService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Models.MediumPartner>>> GetAllPartners()
        {
            return Ok(await _mediumPartnerService.GetAllPartners());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Models.MediumPartner>> GetSinglePartner(int id)
        {
            var result = await _mediumPartnerService.GetSinglePartner(id);
            if (result is null)
                return NotFound("Sorry, but this record doesn't exist");
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Models.MediumPartner>>> AddPartner(Models.MediumPartner newPartner)
        {
            return Ok(await _mediumPartnerService.AddPartner(newPartner));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Models.MediumPartner>>> UpdatePartner(int id, Models.MediumPartner updatePartner)
        {

            return Ok(await _mediumPartnerService.UpdatePartner(id, updatePartner));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Models.MediumPartner>>> DeletedPartner(int id)
        {
            var result  = await _mediumPartnerService.DeletedPartner(id);
            if (result is null)
                return NotFound("Sorry, but this record doesn't exist");

            return Ok(result);
        }


    }
}
