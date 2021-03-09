using GamerJogoVelhaDomain.Entities;
using GamerJogoVelhaDomain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace GamerJogoVelhaAPI.Controllers
{
    /// <summary>
    /// Criando Player
    /// </summary>
    [Route("v1/player")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly IPlayerService _playerService;

        public PlayerController(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        /// <summary>
        /// Gravando informações do Player
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Register([FromBody] Player player)
        {
            try
            {
                _playerService.Insert(player);

                return Ok(player.Id);
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
        /// Atualizando informações do Player
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult Update([FromBody] Player player)
        {
            try
            {
                _playerService.Update(player);

                return Ok(player);
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
        /// Removendo Player por ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Remove([FromRoute] long id)
        {
            try
            {
                _playerService.Delete(id);

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
        /// Lista de todos os Players
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult RecoverAll()
        {
            try
            {
                return Ok(_playerService.Browse());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Busca de Player por ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult Recover([FromRoute] long id)
        {
            try
            {
                return Ok(_playerService.RecoverById(id));
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
