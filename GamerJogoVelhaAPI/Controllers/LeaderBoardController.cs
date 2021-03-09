using AutoMapper;
using GamerJogoVelhaDomain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace GamerJogoVelhaAPI.Controllers
{
    [Route("v1/leaderboard")]
    [ApiController]
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


        [Route("")]
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

        [Route("")]
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
