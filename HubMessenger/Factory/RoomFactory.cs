using HubMessenger.Models;

namespace HubMessenger.Factory;

public class RoomFactory : IRoomFactory
{
    private readonly ILogger<RoomFactory> _logger;
    public RoomFactory(ILogger<RoomFactory> logger) 
    { 
        _logger = logger;
    }

    public Room CreateRoom(string name, string hostName)
    {
        return new Room(name, hostName);
    }
}
