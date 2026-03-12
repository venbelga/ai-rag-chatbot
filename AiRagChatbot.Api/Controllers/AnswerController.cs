using AiRagChatbot.Application.DTOs;
using AiRagChatbot.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AiRagChatbot.Api.Controllers
{
    [ApiController]
    [Route("api/answers")]
    public class AnswerController : ControllerBase
    {
        private readonly IAnswerEvaluator _evaluator;

        public AnswerController(IAnswerEvaluator evaluator)
        {
            _evaluator = evaluator;
        }

        [HttpPost("evaluate")]
        public IActionResult Evaluate([FromBody] AnswerEvaluationRequest request)
        {
            var result = _evaluator.Evaluate(request);

            return Ok(result);
        }
    }
}