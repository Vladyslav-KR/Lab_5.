public class Human
{
    public double Speed { get; set; }

    public Human(double speed)
    {
        Speed = speed;
    }

    public void Move()
    {
        Console.WriteLine($"Людина рухається зі швидкістю {Speed} км/год.");
    }
}
