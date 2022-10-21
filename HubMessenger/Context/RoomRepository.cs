using HubMessenger.Factory;
using HubMessenger.Models;

namespace HubMessenger.Context
{
    public interface IRoomRepository
    {
        public Room Get(Guid id);
        public List<Room> GetRooms();
        public Room CreateRoom(string name, string hostName);
    }

    public class RoomRepository : IRoomRepository
    {
        private readonly ILogger<RoomRepository> _logger;
        private readonly IRoomFactory _roomFactory;
        private Hub Hub { get; set; }
        public RoomRepository(ILogger<RoomRepository> logger, IRoomFactory roomFactory)
        {
            _logger = logger;
            _roomFactory = roomFactory;
            Hub = Hub.GetInstance();
        }

        public Room? Get(Guid id)
        {
            return Hub.Rooms.SingleOrDefault(x => x.Id == id);
        }

        public List<Room> GetRooms()
        {
            return Hub.Rooms;
        }
        public Room CreateRoom(string name, string hostName)
        {
            //need to establish a kafka connection there
            var room = _roomFactory.CreateRoom(name, hostName);
            Hub.Rooms.Add(room);

            return room;
        }

    }
}
