using HubMessenger.Models;

namespace HubMessenger.ViewModels;

public class RoomViewModel
{
    public RoomViewModel(Room room)
    {
        Id = room.Id;
        HostName = room.HostName;
        RoomName = room.Name;
    }
    public Guid Id { get; set; }
    public string HostName { get; set; }
    public string RoomName { get; set; }
}
