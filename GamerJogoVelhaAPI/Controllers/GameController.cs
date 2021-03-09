using AutoMapper;
using GamerJogoVelhaDomain.Entities;
using GamerJogoVelhaDomain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace GamerJogoVelhaAPI.Controllers
{
    /// <summary>
    /// Criando Game
    /// </summary>
    [Route("v1/game")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly IGameService _gameService;

        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }

        /// <summary>
        /// Gravando o Game criado
        /// </summary>
        /// <param name="game"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Register([FromBody] Game game)
        {
            try
            {
                _gameService.Insert(game);

                return Ok(game.Id);
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

        /// <summary>
        /// Atualizando Game exitente
        /// </summary>
        /// <param name="game"></param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult Update([FromBody] Game game)
        {
            try
            {
                _gameService.Update(game);

                return Ok(game);
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

        /// <summary>
        /// Removendo Game
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Remove([FromRoute] long id)
        {
            try
            {
                _gameService.Delete(id);

                return NoContent();
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

        /// <summary>
        /// Buscando todos os games
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult RecoverAll()
        {
            try
            {
                return Ok(_gameService.Browse());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Buscando um Game espeficico por ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult Recover([FromRoute] long id)
        {
            try
            {
                return Ok(_gameService.RecoverById(id));
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
