using HubMessenger.Context;
using HubMessenger.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace HubMessenger.Controllers
{
    [Authorize]
    public class HubController : Controller
    {
        private readonly ILogger<HubController> _logger;
        private IRoomRepository _roomRepository;
        public HubController(ILogger<HubController> logger, IRoomRepository roomRepository)
        {
            _logger = logger;
            _roomRepository = roomRepository;
        }
        public IActionResult Index()
        {
            var viewModel = new HubViewModel();
            var rooms = _roomRepository.GetRooms();
            viewModel.ActiveRooms = rooms.Select(room => new ActiveRoomViewModel(room)).ToList();

            return View(viewModel);
        }

        public IActionResult CreateRoom(string name, string hostName)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrEmpty(hostName))
                return BadRequest("Invalid parameters.");

            var room = _roomRepository.CreateRoom(name, hostName);

            return Redirect($"~/Room/Index/{room.Id}");
        }
    }
}
