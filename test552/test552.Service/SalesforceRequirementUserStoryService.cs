using Test552.DataAccess;
using Test552.DTO;
using MongoDB.Driver;
using System.Threading.Tasks;

namespace Test552.Service
{
    public class SalesforceRequirementUserStoryService : ISalesforceRequirementUserStoryService
    {
        private readonly ISalesforceRequirementUserStoryRepository _salesforceRequirementUserStoryRepository;

        public SalesforceRequirementUserStoryService(ISalesforceRequirementUserStoryRepository salesforceRequirementUserStoryRepository)
        {
            _salesforceRequirementUserStoryRepository = salesforceRequirementUserStoryRepository;
        }

        public async Task<SalesforceRequirementUserStoryModel> GetSalesforceRequirementUserStoryAsync(Guid id)
        {
            return await _salesforceRequirementUserStoryRepository.Get(id);
        }

        public async Task CreateSalesforceRequirementUserStoryAsync(SalesforceRequirementUserStoryDTO salesforceRequirementUserStoryDTO)
        {
            var model = MapSalesforceRequirementUserStoryDTO(salesforceRequirementUserStoryDTO);
            await _salesforceRequirementUserStoryRepository.Create(model);
        }

        public async Task UpdateSalesforceRequirementUserStoryAsync(SalesforceRequirementUserStoryDTO salesforceRequirementUserStoryDTO)
        {
            var model = MapSalesforceRequirementUserStoryDTO(salesforceRequirementUserStoryDTO);
            await _salesforceRequirementUserStoryRepository.Update(model);
        }

        public async Task RemoveSalesforceRequirementUserStoryAsync(Guid id)
        {
            await _salesforceRequirementUserStoryRepository.Remove(id);
        }

        private SalesforceRequirementUserStoryModel MapSalesforceRequirementUserStoryDTO(SalesforceRequirementUserStoryDTO salesforceRequirementUserStoryDTO)
        {
            return new SalesforceRequirementUserStoryModel
            {
                Id = salesforceRequirementUserStoryDTO.Id,
                // ...
            };
        }

        public async Task<IEnumerable<SalesforceRequirementUserStoryModel>> GetAllSalesforceRequirementUserStoryAsync()
        {
            return await _salesforceRequirementUserStoryRepository.GetAll();
        }
    }
}