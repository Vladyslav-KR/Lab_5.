public class Route
{
    public string StartPoint { get; set; }
    public string EndPoint { get; set; }
    public double Distance { get; set; } // Відстань у кілометрах

    public Route(string startPoint, string endPoint, double distance)
    {
        StartPoint = startPoint;
        EndPoint = endPoint;
        Distance = distance;
    }

    /// <summary>
    /// Розрахунок оптимального маршруту на основі швидкості транспорту.
    /// </summary>
    /// <param name="vehicle">Транспортний засіб</param>
    /// <returns>Час у годинах</returns>
    public double CalculateOptimalRoute(Vehicle vehicle)
    {
        if (vehicle.Speed <= 0)
        {
            throw new InvalidOperationException("Швидкість транспорту повинна бути більшою за 0.");
        }

        // Розрахунок часу: час = відстань / швидкість
        return Distance / vehicle.Speed;
    }

    public void DisplayRouteInfo(Vehicle vehicle)
    {
        double time = CalculateOptimalRoute(vehicle);
        Console.WriteLine($"Маршрут від {StartPoint} до {EndPoint}:");
        Console.WriteLine($"Відстань: {Distance} км.");
        Console.WriteLine($"Оптимальний час у дорозі на {vehicle.GetType().Name}: {time:F2} годин.");
    }
}


