using AutoMapper;
using GamerJogoVelhaDomain.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamerJogoVelhaAPI.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class LeaderBoardController : ControllerBase
    {
        public readonly IGameResultService _service;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="repo"></param>
        /// <param name="mapper"></param>
        public LeaderBoardController(IGameResultService repo, IMapper mapper)
        {
            _service = repo;
        }


        [HttpGet]
        public IActionResult RecoverAll()
        {
           try
           {
              return Ok(_service.Browse());
           }
           catch (Exception ex)
           {
              return BadRequest(ex);
           }
        }

        [HttpGet("{id}")]
        public IActionResult Recover([FromRoute] int id)
        {
            try
            {
               return Ok(_service.RecoverById(id));
            }
            catch (ArgumentException ex)
            {
               return NotFound(ex);
            }
            catch (Exception ex)
            {
               return BadRequest(ex);
            }
        }
        
    }
}
