public class Car : Vehicle
{
    public Car(double speed, int capacity) : base(speed, capacity)
    {
    }

    public override void Move()
    {
        Console.WriteLine("Автомобіль рухається зі швидкістю" + Speed + " км/год");
    }
}
