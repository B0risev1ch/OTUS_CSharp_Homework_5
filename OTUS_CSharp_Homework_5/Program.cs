Quadrocopter quadrocopter = new();

Console.WriteLine($"{quadrocopter.GetInfo()}");
Console.WriteLine($"{quadrocopter.GetRobotType()}");
Console.WriteLine($"{(string.Join(", ", quadrocopter.GetComponents))}");
quadrocopter.Charge();
