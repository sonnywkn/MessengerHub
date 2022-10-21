using HubMessenger.Models;

namespace HubMessenger.Factory;

public interface IRoomFactory
{
    Room CreateRoom(string name, string hostName);
}
