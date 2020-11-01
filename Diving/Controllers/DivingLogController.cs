using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using DivingLogs.Models;
using DivingLogs.Data;
using AutoMapper;
using DivingLogs.Dtos;

namespace DivingLogs.Controller
{   
    [Route("api/divings")]
    [ApiController]
    public class DivingLogController : ControllerBase
    {
        
        private readonly IDivingLogRepo _repository;
        private readonly IMapper _mapper;
        
        public DivingLogController(IDivingLogRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
       //----------------------------------------------------------------------------------------
       
        // GET api/Divings
        [HttpGet]
        public ActionResult <IEnumerable<DivingLogReadDto>> GetAllDivingLog()
        {
            var divingItems = _repository.GetAllDivings();
            return Ok(_mapper.Map<IEnumerable<DivingLogReadDto>>(divingItems));
        }
        //----------------------------------------------------------------------------------------
        
        // GET api/Divings/0
        [HttpGet("{id}")]
        public ActionResult <DivingLogReadDto> GetDivingLogById(int id)
        {
            var divingItem = _repository.GetDivingLogById(id);
            if (divingItem != null){
                return Ok(_mapper.Map<DivingLogReadDto>(divingItem));
            }   
            return NotFound();
        }

        //----------------------------------------------------------------------------------------

        // POST api/Divings/0
        [HttpPost]
        public ActionResult <DivingLogReadDto> createDivingLog(DivingLogCreateDto divingLogCreateDto)
        {
            var divingModel = _mapper.Map<DivingLog>(divingLogCreateDto);
            _repository.CreateDivingLog(divingModel);
            _repository.SaveChanges();
            var divingLogReadDto = _mapper.Map <DivingLogReadDto>(divingModel);                    
            return Ok(divingLogReadDto);
        }
    }
}