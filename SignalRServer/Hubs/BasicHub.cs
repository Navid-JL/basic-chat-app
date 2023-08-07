using Microsoft.AspNetCore.SignalR;

namespace SignalRServer.Hubs;

public class BasicHub : Hub<IBasicHubClient>
{
    public async Task BroadcastMessage(string message)
    {
        await Clients.All.ReceiveMessage(message);
    }

    public override async Task OnConnectedAsync()
    {
        await base.OnConnectedAsync();
    }

    public override async Task OnDisconnectedAsync(Exception? exception)
    {
        await base.OnDisconnectedAsync(exception);
    }
}