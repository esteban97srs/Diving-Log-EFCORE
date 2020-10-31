using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using DivingLogs.Models;
using DivingLogs.Data;

namespace DivingLogs.Controller
{   
    [Route("api/divings")]
    [ApiController]
    public class DivingLogController : ControllerBase
    {
        private readonly IDivingLogRepo _repository;
        
        public DivingLogController(IDivingLogRepo repository)
        {
            _repository = repository;
        }

        // Get api/DivingLogs
        [HttpGet]
        public ActionResult <IEnumerable<DivingLog>> GetAllDivingLog()
        {
            var divingItems = _repository.GetAllDivings();
            return Ok(divingItems);
        }
        // Get api/DivingLogs/0
        [HttpGet("{id}")]
        public ActionResult <DivingLog> GetDivingLogById(int id)
        {
            var divingItem = _repository.GetDivingLogById(id);
            return Ok(divingItem);
        }
    }
}