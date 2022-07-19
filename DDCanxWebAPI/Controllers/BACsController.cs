using DDCanxWebAPI.Data;
using DDCanxWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DDCanxWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BACsController : ControllerBase
    {
        private readonly BACSDbContext _bacsDbContext;

        public BACsController(BACSDbContext bacsDbContext)
        {
            _bacsDbContext = bacsDbContext;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAllRecords()
        {
            var currentBACs = await _bacsDbContext.BACs.ToListAsync();
            return Ok(currentBACs);
        }

        [HttpGet]
        [Route("{PolicyRef:}")]
        public async Task<IActionResult> GetRecord([FromRoute] String PolicyRef)
        {
            var existingBACs = await _bacsDbContext.BACs.FindAsync(PolicyRef);

            if (existingBACs == null)
            {
                return NotFound();
            }

            return Ok(existingBACs);
        }

        [HttpPost]
        public async Task<IActionResult> AddRecord(AddBACs addBACs)
        {
            var BACsRecord = new BACs()
            {
                PolicyRef = addBACs.PolicyRef,
                Amount = addBACs.Amount,
                ContinueDD = addBACs.ContinueDD,
                PaidBy = addBACs.PaidBy,
                NewDate = addBACs.NewDate,
                ChangeDate = addBACs.ChangeDate,
                Branch = addBACs.Branch,
                DueDate = addBACs.DueDate
            };

            await _bacsDbContext.BACs.AddAsync(BACsRecord);
            await _bacsDbContext.SaveChangesAsync();
            return Ok(BACsRecord);
        }

        [HttpPut]
        [Route("{PolicyRef:}")]
        public async Task<IActionResult> UpdateRecord([FromRoute] String PolicyRef, UpdateBACs updateBACs)
        {
            var existingBACs = await _bacsDbContext.BACs.FindAsync(PolicyRef);

            if (existingBACs != null)
            {
                existingBACs.Amount = updateBACs.Amount;
                existingBACs.ContinueDD = updateBACs.ContinueDD;
                existingBACs.PaidBy = updateBACs.PaidBy;
                existingBACs.NewDate = updateBACs.NewDate;
                existingBACs.ChangeDate = updateBACs.ChangeDate;
                existingBACs.Branch = updateBACs.Branch;
                existingBACs.DueDate = updateBACs.DueDate;

                await _bacsDbContext.SaveChangesAsync();
                return Ok(existingBACs);
            }

            return NotFound();
        }

        [HttpDelete]
        [Route("{PolicyRef:}")]
        public async Task<IActionResult> DeleteRecord([FromRoute] String PolicyRef)
        {
            var existingBACs = await _bacsDbContext.BACs.FindAsync(PolicyRef);

            if (existingBACs != null)
            {
                _bacsDbContext.Remove(existingBACs);
                _bacsDbContext.SaveChanges();
                return Ok(existingBACs);
            }

            return NotFound();
        }
    }
}