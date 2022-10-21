namespace HubMessenger.Models;

public class Hub
{
    private Hub() { }

    private static Hub _instance;

    public static Hub GetInstance()
    {
        if (_instance == null) {
            _instance = new Hub();
        }

        return _instance;
    }

    public List<Room> Rooms = new List<Room>();
}
