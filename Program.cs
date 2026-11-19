using FizzBuzz;
var detector = new FizzBuzzDetector();
string input = "";
string? line;
while ((line = Console.ReadLine()) != null)
{
    input += line + "\n";
}
var result = detector.getOverlappings(input);
Console.WriteLine($"Output string:\n{result.Output}");
Console.WriteLine($"Count: {result.Count}");
