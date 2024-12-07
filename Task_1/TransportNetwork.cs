public class TransportNetwork
{
    private List<Vehicle> vehicles;

    public TransportNetwork()
    {
        vehicles = new List<Vehicle>();
    }

    public void AddVehicle(Vehicle vehicle)
    {
        vehicles.Add(vehicle);
        Console.WriteLine("Транспортний засіб додано в мережу.");
    }

    public void StartAllVehicles()
    {
        foreach (var vehicle in vehicles)
        {
            vehicle.Move();
        }
    }
}

