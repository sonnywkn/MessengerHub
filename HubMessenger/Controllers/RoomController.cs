using HubMessenger.Context;
using HubMessenger.Models;
using HubMessenger.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HubMessenger.Controllers
{
    public class RoomController : Controller
    {
        private readonly ILogger<RoomController> _logger;
        private readonly IRoomRepository _roomRepository;

        public RoomController(ILogger<RoomController> logger, IRoomRepository roomRepository)
        {
            _logger = logger;
            _roomRepository = roomRepository;
        }

        public IActionResult Index(Guid id)
        {
            var room = _roomRepository.Get(id);
            if (room == null) 
                return NotFound("Room does not exist.");

            return View(new RoomViewModel(room));
        }

        public IActionResult Send(string name, string message)
        {
            return Ok();
        }
    }
}
