using GamerJogoVelhaDomain.Entities;
using GamerJogoVelhaDomain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace GamerJogoVelhaAPI.Controllers
{
    /// <summary>
    /// API DE CONTROLE DE RESULTADO JOGOS
    /// </summary>
    [Route("v1/gameresult")]
    [ApiController]
    public class GameResultController : ControllerBase
    {
        public readonly IGameResultService _service;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="servce"></param>
        public GameResultController(IGameResultService service)
        {
            _service = service;
        }

        /// <summary>
        /// Metodo de gravar o resultado do jogo
        /// </summary>
        /// <param name="gameResult"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Register([FromBody]  GameResult gameResult)
        {
            try
            {
                for (int i = 10; i < gameResult.PartGame; i++)
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

        /// <summary>
        /// Atualização PartGame 
        /// </summary>
        /// <param name="game"></param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult Update([FromBody] GameResult game)
        {
            try
            {
                _service.Update(game);

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
    }
}
