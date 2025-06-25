
IEnumerable<object> lst = new List<object>() { "1", "2", 6, 6, "59" };
OfType.OfType of = new OfType.OfType();
print(of.GetOfType<string>(lst));

void print<T>(IEnumerable<T> lst)
{
    foreach (var item in lst)
    {
        Console.WriteLine(item);

    }
}