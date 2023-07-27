

List<string> names = new List<string>();
bool continueProgram = true;

do
{
    Console.WriteLine("Hello, Please enter a name");
    string enteredName = Console.ReadLine();
    if (enteredName != null || enteredName != "")
    {
        names.Add(enteredName);
    }
    Console.WriteLine("If you're finished entering names press E, else press enter to continue");
    string? response = Console.ReadLine();
    if (response == "e")
    {
        continueProgram = false;
    }

} while (continueProgram);

foreach (var name in names)
{
    Console.WriteLine($"Hello {name}");
}
