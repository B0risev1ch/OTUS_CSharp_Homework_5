
public interface IRobot
{
    string GetInfo();
    List<string>? GetComponents { get; }
    string GetRobotType { get => "I am a simple robot."; }
}
