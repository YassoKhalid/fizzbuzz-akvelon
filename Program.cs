using FizzBuzz;
var detector = new FizzBuzzDetector();
string input = Console.In.ReadToEnd();

try
{
    var result = detector.getOverlappings(input);
    Console.WriteLine($"Output string:\n{result.Output}");
    Console.WriteLine($"Count: {result.Count}");
}
catch (ArgumentException exception)
{
    Console.Error.WriteLine(exception.Message);
    Environment.ExitCode = 1;
}
