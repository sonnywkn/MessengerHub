namespace HubMessenger.Models;

public class Room
{
	public Room(string name, string hostName)
	{
		Id = Guid.NewGuid();
		Name = name;
		HostName = hostName;
	}

	public Guid Id { get; set; }
    public string Name { get; set; }
	public string HostName { get; set; }
}
