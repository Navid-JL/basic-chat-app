namespace SignalRServer;

public interface IBasicHubClient
{
    Task ReceiveMessage(string message);
}
