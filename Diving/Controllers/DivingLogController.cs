using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using DivingLogs.Models;
using DivingLogs.Data;
using AutoMapper;
using DivingLogs.Dtos;
using Microsoft.AspNetCore.Cors;

namespace DivingLogs.Controller{

    [Route("api/divings/")]
    [EnableCors("MyPolicy")]
    [Produces("application/json")]
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
        // GET api/divings
        [HttpGet]
        public ActionResult <IEnumerable<DivingLogReadDto>> GetAllDivingLog()
        {          
            var divingItems = _repository.GetAllDivings();
            return Ok(_mapper.Map<IEnumerable<DivingLogReadDto>>(divingItems));
        }
        //----------------------------------------------------------------------------------------
        
        // GET api/divings/0
        [HttpGet("{id}", Name = "GetDivingLogById")]
        public ActionResult <DivingLogReadDto> GetDivingLogById(int id)
        {
            var divingItem = _repository.GetDivingLogById(id);
            if (divingItem != null){
                return Ok(_mapper.Map<DivingLogReadDto>(divingItem));
            }
            return NotFound();
        }
        //----------------------------------------------------------------------------------------
        // POST api/divings/
        [HttpPost]
        public ActionResult <DivingLogReadDto> CreateDivingLog(DivingLogCreateDto divingLogCreateDto)
        {
            var divingModel = _mapper.Map<DivingLog>(divingLogCreateDto);
            _repository.CreateDivingLog(divingModel);
            _repository.SaveChanges();
            var divingLogReadDto = _mapper.Map<DivingLogReadDto>(divingModel);
            return CreatedAtRoute(nameof(GetDivingLogById), new { Id = divingLogReadDto }, divingLogReadDto);
        }
        //----------------------------------------------------------------------------------------        
        // PUT api/divings/{id}

        [HttpPut("{id}")]
        public ActionResult <DivingLogReadDto> UpdateDivingLog(int id, DivingLogUpdateDto divingLogUpdateDto){
            var divingModelFromRepo = _repository.GetDivingLogById(id);
            _mapper.Map(divingLogUpdateDto, divingModelFromRepo);
            _repository.UpdateDivingLog(divingModelFromRepo);
            _repository.SaveChanges();
            return Ok();
        }
        //----------------------------------------------------------------------------------------
        // Delete api/divings/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteDivingLog(int id){
            var divingModelFromRepo = _repository.GetDivingLogById(id);
            if(divingModelFromRepo == null){
                return NotFound();
            }
            _repository.DeleteDivingLog(divingModelFromRepo);
            _repository.SaveChanges();
            return Ok();
        }
    }
}