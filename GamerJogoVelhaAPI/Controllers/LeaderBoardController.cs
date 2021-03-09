using GamerJogoVelhaDomain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace GamerJogoVelhaAPI.Controllers
{
    /// <summary>
    /// Fonte de informação para Dashboard
    /// </summary>
    [Route("v1/leaderboard")]
    [ApiController]
    public class LeaderBoardController : ControllerBase
    {
        public readonly IGameResultService _gameResultService;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="repo"></param>
        public LeaderBoardController(IGameResultService gameResultService)
        {
            _gameResultService = gameResultService;
        }

        /// <summary>
        /// Busca todos os resultados dos Players
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult RecoverAll()
        {
            try
            {
                var result = _gameResultService.Browse();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Buscar os resultado de um Player por ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult Recover([FromRoute] long id)
        {
            try
            {
                var result = _gameResultService.RecoverById(id);
                return Ok(result);
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
