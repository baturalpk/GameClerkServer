namespace GameClerkServer.Features.GameplayActivity;

public class GameplayActivity
{
    public Guid Id { get; set; }
    public string PlayerId { get; set; }
    public string TypeId { get; set; }
    public string Value { get; set; }

    public GameplayActivity(string playerId, string typeId, string value)
    {
        Id = Guid.NewGuid();

        PlayerId = playerId;
        TypeId = typeId;
        Value = value;
    }
}
