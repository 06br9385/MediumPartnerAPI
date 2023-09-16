using MediumPartnerAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MediumPartnerAPI.Services.PartnerService
{
    public class MediumPartnerService : IMediumPartnerService
    {
        private static List<Models.MediumPartner> mediumPartners = new List<Models.MediumPartner>
        {
            new Models.MediumPartner
            {
                Id = 1,
                Name = "TestUser1",
                FirstName = "Test1",
                LastName = "User1",
                Place = "New York City"
            },
            new Models.MediumPartner
            {
                Id = 2,
                Name = "TestUser2",
                FirstName = "Test2",
                LastName = "User2",
                Place = "Paris City"
            }
        };
        public async Task<ActionResult<List<MediumPartner>>> AddPartner(MediumPartner newPartner)
        {
            mediumPartners.Add(newPartner);
            return mediumPartners;
        }

        public async Task<ActionResult<List<MediumPartner>>> DeletedPartner(int id)
        {
            var partner = mediumPartners.Find(x => x.Id == id);
            if (partner is null)
                return null;

            mediumPartners.Remove(partner);

            return mediumPartners;
        }

        public async Task<ActionResult<List<MediumPartner>>> GetAllPartners()
        {
            return mediumPartners;
        }

        public async Task<ActionResult<MediumPartner>> GetSinglePartner(int id)
        {
            var partner = mediumPartners.Find(x => x.Id == id);
            if (partner is null)
                return null;

            return partner;
        }

        public async Task<ActionResult<List<MediumPartner>>> UpdatePartner(int id, MediumPartner updatePartner)
        {
            var partner = mediumPartners.Find(x => x.Id == id);
            if (partner is null)
                return null;

            partner.Name = updatePartner.Name;
            partner.FirstName = updatePartner.FirstName;
            partner.LastName = updatePartner.LastName;
            partner.Place = updatePartner.Place;

            return mediumPartners;
        }
    }
}
