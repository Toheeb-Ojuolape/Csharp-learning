string[] frauds = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
string[] fraudulent_users = { };
foreach (string fraud in frauds)
{
    if (fraud.StartsWith('B'))
    {
        Console.WriteLine(fraud);
    }
}

Console.WriteLine(fraudulent_users.ToString());