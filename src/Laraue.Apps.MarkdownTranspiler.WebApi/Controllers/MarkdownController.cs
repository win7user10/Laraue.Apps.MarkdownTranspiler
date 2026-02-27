using Laraue.Apps.MarkdownTranspiler.Contracts;
using Laraue.Apps.MarkdownTranspiler.Services;
using Microsoft.AspNetCore.Mvc;

namespace Laraue.Apps.MarkdownTranspiler.WebApi.Controllers;

[ApiController]
[Route("api/markdown")]
public class MarkdownController(IMarkdownTranspilerService transpilerService) : ControllerBase
{
    [HttpPost("transpile")]
    public MarkdownTranspileResponse Transpile([FromBody] MarkdownTranspileRequest request)
    {
        return transpilerService.Transpile(request);
    }
}