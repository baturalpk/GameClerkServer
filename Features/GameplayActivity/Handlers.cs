using GameClerkServer.Data;
using Microsoft.AspNetCore.Mvc;

namespace GameClerkServer.Features.GameplayActivity;

[ApiController]
[Produces("application/json")]
public class Handlers : ControllerBase
{
    private readonly DataContext _context;

    public Handlers(DataContext context)
    {
        _context = context;
    }

    [HttpPost]
    [Route("activity/")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult Insert([FromBody] InsertRequestDTO body)
    {
        var uid = Guid.NewGuid().ToString(); // TODO: Retrieve User ID from auth layer.

        foreach (var fragment in body.Fragments)
        {
            var gameplayActivity = new GameplayActivity(uid, fragment.TypeId, fragment.Value);
            _context.Add(gameplayActivity);
        }

        _context.SaveChanges();
        return Created("activity/", null);
    }
}

public record InsertRequestDTO(InsertRequestDTOFragment[] Fragments);

public class InsertRequestDTOFragment
{
    public string TypeId { get; set; }
    public string Value { get; set; }
}
