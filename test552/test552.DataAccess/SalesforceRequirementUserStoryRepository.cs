using MongoDB.Driver;
using System.Threading.Tasks;

namespace Test552
{
    public class SalesforceRequirementUserStoryRepository : ISalesforceRequirementUserStoryRepository
    {
        private readonly IMongoCollection<SalesforceRequirementUserStoryModel> _salesforceRequirementUserStory;

        public SalesforceRequirementUserStoryRepository(IMongoDatabase database)
        {
            _salesforceRequirementUserStory = database.GetCollection<SalesforceRequirementUserStoryModel>("SalesforceRequirementUserStory");
        }

        public async Task<SalesforceRequirementUserStoryModel> Get(Guid id)
        {
            return await _salesforceRequirementUserStory.Find(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<SalesforceRequirementUserStoryModel> Create(SalesforceRequirementUserStoryModel model)
        {
            await _salesforceRequirementUserStory.InsertOneAsync(model);
            return model;
        }

        public async Task Update(SalesforceRequirementUserStoryModel model)
        {
            await _salesforceRequirementUserStory.ReplaceOneAsync(x => x.Id == model.Id, model);
        }

        public async Task Remove(Guid id)
        {
            await _salesforceRequirementUserStory.DeleteOneAsync(x => x.Id == id);
        }
    }

    public interface ISalesforceRequirementUserStoryRepository
    {
        Task<SalesforceRequirementUserStoryModel> Get(Guid id);
        Task<SalesforceRequirementUserStoryModel> Create(SalesforceRequirementUserStoryModel model);
        Task Update(SalesforceRequirementUserStoryModel model);
        Task Remove(Guid id);
    }
}