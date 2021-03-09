using AutoMapper;
using GamerJogoVelhaDomain.DTOs;
using GamerJogoVelhaDomain.Entities;
using GamerJogoVelhaDomain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace GamerJogoVelhaAPI.Controllers
{
    [Route("v1/player")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly IPlayerService _playerService;
        private readonly IMapper _mapper;

        public PlayerController(IPlayerService playerService, IMapper mapper)
        {
            _playerService = playerService;
            _mapper = mapper;
        }

        [Route("")]
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

        [Route("")]
        [HttpPut("{id}")]
        public IActionResult Update([FromBody] long id, PlayerDto playerDto)
        {
            var player = _playerService.RecoverById(id);
            if (player == null)
            {
                return BadRequest("Game não encontrado!");
            }

            _mapper.Map(playerDto, player);

            _playerService.Update(player);
            if (_playerService.Update(player) != null)
            {
                return Created($"/api/aluno/{player.Id}", _mapper.Map<GameDto>(player));
            }
            return BadRequest("Game não Atualizado.");
        }

        [Route("")]
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

        [Route("")]
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

        [Route("")]
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
