while (true)
{
    Console.Write("Enter some words separated by a space to turn it into PascalCase: ");
    var input = Console.ReadLine();
    if (String.IsNullOrWhiteSpace(input))
        break;
    Console.WriteLine(Pascalize(input));
}

static string Pascalize(string input)
{
    var firstLetterofEachWord = string.Join("", input.Split(' ').ToList().ConvertAll(word => word.Substring(0, 1).ToUpper() + word.Substring(1)));
    return firstLetterofEachWord;
}