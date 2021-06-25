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
    public class CaseTypesController : ControllerBase
    {
        ICaseTypeService _caseTypeService;

        public CaseTypesController(ICaseTypeService caseTypeService)
        {
            _caseTypeService = caseTypeService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _caseTypeService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(CaseType caseType)
        {
            var result = _caseTypeService.Add(caseType);
            if (result.Success)
            {
                return Ok(result);
            }return BadRequest(result);
        }
    }
}
