using AutoMapper;
using GamerJogoVelhaDomain.DTOs;
using GamerJogoVelhaDomain.Entities;
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
    public class GameController : ControllerBase
    {
        private readonly IGameService _gameService;
        private readonly IMapper _mapper;

        public GameController(IGameService gameService, IMapper mapper)
        {
            _gameService = gameService;
            _mapper = mapper;
        }

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

        [HttpPut]
        public IActionResult Update([FromBody] long id, GameDto gameDto)
        {
            var game = _gameService.RecoverById(id);
            if (game == null)
            {
                return BadRequest("Game não encontrado!");
            }

            _mapper.Map(gameDto, game);

            _gameService.Update(game);
            if (_gameService.Update(game) != null)
            {
                return Created($"/api/aluno/{game.Id}", _mapper.Map<GameDto>(game));
            }
            return BadRequest("Game não Atualizado.");
        }

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
