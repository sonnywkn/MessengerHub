using HubMessenger.Models;

namespace HubMessenger.ViewModels;

public class ActiveRoomViewModel
{
    public ActiveRoomViewModel(Room room)
    {
        Id = room.Id;
        Name = room.Name;
        HostName = room.HostName;
    }
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string HostName { get; set; }
}
