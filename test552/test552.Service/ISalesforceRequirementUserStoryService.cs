using Test552.DataAccess;
using Test552.DTO;

namespace Test552.Service
{
    public interface ISalesforceRequirementUserStoryService
    {
        Task<SalesforceRequirementUserStoryModel> GetSalesforceRequirementUserStoryAsync(Guid id);
        Task CreateSalesforceRequirementUserStoryAsync(SalesforceRequirementUserStoryDTO salesforceRequirementUserStoryDTO);
        Task UpdateSalesforceRequirementUserStoryAsync(SalesforceRequirementUserStoryDTO salesforceRequirementUserStoryDTO);
        Task RemoveSalesforceRequirementUserStoryAsync(Guid id);
    }
}