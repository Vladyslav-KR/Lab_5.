public class Train : Vehicle
{
    public Train(double speed, int capacity) : base(speed, capacity)
    {
    }

    public override void Move()
    {
        Console.WriteLine("Потяг рухається зі швидкістю" + Speed + " км/год");
    }
}

