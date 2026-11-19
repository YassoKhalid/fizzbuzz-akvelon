# FizzBuzz

A C# console application that replaces words according to their positions.

Requires the .NET 10 SDK. Run from the project folder:

```bash
dotnet run
```

Enter your text, then finish input on a new line with **Ctrl+D** on Linux/macOS
or **Ctrl+Z, Enter** on Windows.

Input must not be null and must contain **7 to 100 characters**, including spaces
and line breaks. Invalid input produces an error message and exit code 1.
To supply text without a trailing newline on Linux/macOS:

```bash
printf '%s' 'one two three four five' | dotnet run
```

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

`Program.cs` reads all text until end-of-input, calls the detector, and prints the
result. Punctuation, spaces, and line endings are preserved exactly as supplied.
The assignment's sample is 100 characters with LF line endings and no trailing
newline; additional line-ending characters count toward the limit.

Run the unit tests:

```bash
dotnet test tests/FizzBuzz.Tests.csproj
```
