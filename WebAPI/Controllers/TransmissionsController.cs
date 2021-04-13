using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransmissionsController : ControllerBase
    {
        ITransmissionService _transmissionService;
        public TransmissionsController(ITransmissionService transmissionService)
        {
            _transmissionService = transmissionService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _transmissionService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _transmissionService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Transmission transmission)
        {
            var result = _transmissionService.Add(transmission);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Transmission transmission)
        {
            var result = _transmissionService.Update(transmission);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Transmission transmission)
        {
            var result = _transmissionService.Delete(transmission);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
