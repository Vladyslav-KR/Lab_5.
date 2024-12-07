public abstract class Vehicle
{
    public double Speed { get; set; }
    public int Capacity { get; set; }

    public Vehicle(double speed, int capacity)
    {
        Speed = speed;
        Capacity = capacity;
    }

    // Абстрактний метод для руху
    public abstract void Move();

    // Метод для посадки пасажирів
    public void BoardPassengers(int numberOfPassengers)
    {
        if (numberOfPassengers <= Capacity)
        {
            Console.WriteLine($"{numberOfPassengers} пасажирів сіли в транспорт.");
        }
        else
        {
            Console.WriteLine($"Немає місця для всіх пасажирів! Місткість: {Capacity}");
        }
    }

    // Метод для висадки пасажирів
    public void UnboardPassengers(int numberOfPassengers)
    {
        Console.WriteLine($"{numberOfPassengers} пасажирів вийшли з транспорту.");
    }
}