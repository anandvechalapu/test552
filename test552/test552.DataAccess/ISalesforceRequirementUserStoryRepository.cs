using MongoDB.Driver;
using Test552.DTO;

namespace Test552.Service
{
    public interface ISalesforceRequirementUserStoryRepository
    {
        Task<SalesforceRequirementUserStoryModel> Get(Guid id);
        Task<SalesforceRequirementUserStoryModel> Create(SalesforceRequirementUserStoryModel model);
        Task Update(SalesforceRequirementUserStoryModel model);
        Task Remove(Guid id);
    }
}