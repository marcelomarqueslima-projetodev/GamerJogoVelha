using AutoMapper;
using GamerJogoVelhaDomain.Entities;
using GamerJogoVelhaDomain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace GamerJogoVelhaAPI.Controllers
{
    /// <summary>
    /// API DE CONTROLE DE RESULTADO JOGOS
    /// </summary>
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class GameResultController : ControllerBase
    {
        public readonly IGameResultService _service;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="repo"></param>
        public GameResultController(IGameResultService repo, IMapper mapper)
        {
            _service = repo;
        }

        [HttpPost]
        public IActionResult Register([FromBody] int part, GameResult gameResult)
        {
            try
            {
                for (int i = 10; i < part; i++)
                {
                    var Win = gameResult.Win;
                    _service.Insert(gameResult);
                }

                return Ok(gameResult.Id);
            }
            catch (ArgumentNullException ex)
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
