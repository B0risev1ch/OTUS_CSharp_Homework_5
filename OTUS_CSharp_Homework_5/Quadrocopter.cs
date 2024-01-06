


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
    public string GetRobotType() => IFlyingRobot.GetRobotType;
    //public string GetRobotType() { return "i'm both FlyingRobot and Chargeable"; }
}
