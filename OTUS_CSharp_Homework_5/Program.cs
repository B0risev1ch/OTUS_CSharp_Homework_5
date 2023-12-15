

Quadrocopter quadrocopter = new();

Console.WriteLine($"{quadrocopter.GetInfo()}");
Console.WriteLine($"{quadrocopter.GetRobotType()}");
Console.WriteLine($"{(string.Join(", ", quadrocopter.GetComponents))}");
quadrocopter.Charge();


public interface IRobot
{
    string GetInfo();
    static List<string>? GetComponents;
    static string GetRobotType { get => "I am a simple robot."; }
}
interface IChargeable
{
    void Charge();
    string GetInfo();
}

interface IFlyingRobot : IRobot
{
    static string GetRobotType => "I am a flying robot.";
}

public class Quadrocopter : IFlyingRobot, IChargeable
{
    List<string> _components = new() { "rotor1", "rotor2", "rotor3", "rotor4" };
    public List<string> GetComponents { get => _components; }
    public void Charge()
    {
        Console.WriteLine("Charging...");
        Thread.Sleep(3000);
        Console.WriteLine("Charged !");
    }
    public string GetInfo() { return "I'm a quadrocopter"; }
    public string GetRobotType() { return "i'm both FlyingRobot and Chargeable"; }
}
