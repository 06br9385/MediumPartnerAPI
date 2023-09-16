using Microsoft.AspNetCore.Mvc;

namespace MediumPartnerAPI.Services.PartnerService
{
    public interface IMediumPartnerService
    {
        Task<ActionResult<List<Models.MediumPartner>>> GetAllPartners();
        Task<ActionResult<Models.MediumPartner>> GetSinglePartner(int id);
        Task<ActionResult<List<Models.MediumPartner>>> AddPartner(Models.MediumPartner newPartner);
        Task<ActionResult<List<Models.MediumPartner>>> UpdatePartner(int id, Models.MediumPartner updatePartner);
        Task<ActionResult<List<Models.MediumPartner>>> DeletedPartner(int id);
    }
}
