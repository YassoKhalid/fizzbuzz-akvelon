# FizzBuzz

A C# console application that replaces words according to their positions.

Requires the .NET 10 SDK. Run from the project folder:

```bash
dotnet run
```

Enter your text, then finish input on a new line with **Ctrl+D** on Linux/macOS
or **Ctrl+Z, Enter** on Windows.

Words are numbered starting at 1, continuing across line breaks:

- Every third word becomes `Fizz`.
- Every fifth word becomes `Buzz`.
- Words at positions divisible by both 3 and 5 become `FizzBuzz`.

Words contain ASCII letters and digits. Internal apostrophes keep contractions
such as `It's` together. Other punctuation and whitespace are preserved and do
not increase the word counter.

For example, `one two three four five` becomes `one two Fizz four Buzz`,
with a replacement count of **2**.

`FizzBuzzDetector.getOverlappings(string input)` scans the text manually and
returns a `FizzBuzzResult` containing:

- `Output`: the text after replacement.
- `Count`: the number of replaced words. A `FizzBuzz` replacement counts once.
  Existing `Fizz`, `Buzz`, or `FizzBuzz` words do not increase the count unless
  their position triggers a replacement.

`Program.cs` reads the console input, calls the detector, and prints the result.
The console collects lines until end-of-input, adding a newline after each line.

The input has to be not Null. It is guranteed in the document, that's why I didn't worry about handling it.