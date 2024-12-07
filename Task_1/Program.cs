using System.Net;

class Program
{
    static void Main(string[] args)
    {
        // Встановлення кодування для кирилиці
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        // Створення транспорту
        Vehicle car = new Car(120, 5);  // швидкість 120 км/год, місткість 5 осіб
        Vehicle bus = new Bus(80, 40);  // швидкість 80 км/год, місткість 40 осіб
        Vehicle train = new Train(200, 200); // швидкість 200 км/год, місткість 200 осіб

        // Створення маршруту
        Route route = new Route("Київ", "Львів", 540); // відстань 540 км

        // Розрахунок оптимального маршруту для різних транспортів
        Console.WriteLine("Розрахунок оптимального маршруту:\n");

        // Створення мережі транспорту
        TransportNetwork network = new TransportNetwork();
        network.AddVehicle(car);
        network.AddVehicle(bus);
        network.AddVehicle(train);

        // Розпочати рух всіх транспортних засобів
        network.StartAllVehicles();

        route.DisplayRouteInfo(car);
        Console.WriteLine();
        route.DisplayRouteInfo(bus);
        Console.WriteLine();
        route.DisplayRouteInfo(train);

        // Тестування посадки та висадки пасажирів
        car.BoardPassengers(3);
        bus.BoardPassengers(45); // Перевищує місткість
        train.UnboardPassengers(50);
    }
}

