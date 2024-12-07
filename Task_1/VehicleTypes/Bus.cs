public class Bus : Vehicle
{
    public Bus(double speed, int capacity) : base(speed, capacity)
    {
    }

    public override void Move()
    {
        Console.WriteLine("Автобус рухається зі швидкістю" + Speed + " км/год");
    }
}

