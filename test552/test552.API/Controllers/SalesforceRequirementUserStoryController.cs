using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Test552.DTO;
using Test552.Service;

namespace Test552.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesforceRequirementUserStoryController : ControllerBase
    {
        private readonly SalesforceRequirementUserStoryService _salesforceRequirementUserStoryService;

        public SalesforceRequirementUserStoryController(SalesforceRequirementUserStoryService salesforceRequirementUserStoryService)
        {
            _salesforceRequirementUserStoryService = salesforceRequirementUserStoryService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SalesforceRequirementUserStoryModel>> Get(Guid id)
        {
            var salesforceRequirementUserStory = await _salesforceRequirementUserStoryService.GetSalesforceRequirementUserStoryAsync(id);

            if (salesforceRequirementUserStory == null)
            {
                return NotFound();
            }

            return salesforceRequirementUserStory;
        }

        [HttpPost]
        public async Task<ActionResult<SalesforceRequirementUserStoryModel>> Create([FromBody] SalesforceRequirementUserStoryDTO salesforceRequirementUserStoryDTO)
        {
            await _salesforceRequirementUserStoryService.CreateSalesforceRequirementUserStoryAsync(salesforceRequirementUserStoryDTO);

            return CreatedAtAction(nameof(Get), new { id = salesforceRequirementUserStoryDTO.Id }, salesforceRequirementUserStoryDTO);
        }

        [HttpPut]
        public async Task<ActionResult<SalesforceRequirementUserStoryModel>> Update([FromBody] SalesforceRequirementUserStoryDTO salesforceRequirementUserStoryDTO)
        {
            await _salesforceRequirementUserStoryService.UpdateSalesforceRequirementUserStoryAsync(salesforceRequirementUserStoryDTO);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<SalesforceRequirementUserStoryModel>> Delete(Guid id)
        {
            await _salesforceRequirementUserStoryService.RemoveSalesforceRequirementUserStoryAsync(id);

            return NoContent();
        }
    }
}