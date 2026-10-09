using LinqTutorialSeparated.Basics;
using LinqTutorialSeparated.Projection;
using LinqTutorialSeparated.SelectMany;
using LinqTutorialSeparated.Filtering;
using LinqTutorialSeparated.Sorting;
using LinqTutorialSeparated.Quantifiers;
using LinqTutorialSeparated.SetOperators;
using LinqTutorialSeparated.Partitioning;
using LinqTutorialSeparated.Paging;
using LinqTutorialSeparated.Joins;
using LinqTutorialSeparated.ElementOperators;
using LinqTutorialSeparated;

List<ILinqExample> examples = new()
{
    new QuerySyntaxExample(),
    new MethodSyntaxExample(),
    new MixedSyntaxExample(),
    new IEnumerableExample(),
    new IQueryableExample(),
    new SelectAllExample(),
    new SelectPropertyExample(),
    new SelectNewObjectExample(),
    new SelectAnonymousExample(),
    new SelectWithIndexExample(),
    new SelectManyStringsExample(),
    new SelectManyNestedCollectionExample(),
    new SelectManyDistinctExample(),
    new SelectManyQuerySyntaxExample(),
    new SelectManyWithEmployeeExample(),
    new WhereExample(),
    new WhereMultipleConditionsExample(),
    new WhereWithIndexExample(),
    new OfTypeExample(),
    new OrderByExample(),
    new OrderByDescendingExample(),
    new ThenByExample(),
    new ThenByDescendingExample(),
    new ReverseExample(),
    new AllExample(),
    new AnyExample(),
    new AnyWithConditionExample(),
    new ContainsExample(),
    new DistinctExample(),
    new ExceptExample(),
    new IntersectExample(),
    new UnionExample(),
    new ConcatExample(),
    new TakeExample(),
    new TakeWhileExample(),
    new TakeWhileIndexExample(),
    new SkipExample(),
    new SkipWhileExample(),
    new SkipWhileIndexExample(),
    new SkipTakePagingExample(),
    new InnerJoinMethodExample(),
    new InnerJoinQueryExample(),
    new GroupJoinExample(),
    new LeftOuterJoinExample(),
    new ElementAtExample(),
    new ElementAtOrDefaultExample(),
    new FirstExample(),
    new FirstOrDefaultExample(),
    new LastExample(),
    new LastOrDefaultExample(),
    new SingleExample(),
    new SingleOrDefaultExample(),
    new DefaultIfEmptyExample(),
};

while (true)
{
    Console.Clear();
    Console.WriteLine("LINQ Tutorial - Separate File for Every Concept");
    Console.WriteLine(new string('=', 52));
    for (int i = 0; i < examples.Count; i++)
        Console.WriteLine($"{i + 1,2}. {examples[i].Title}");
    Console.WriteLine(" 0. Exit");
    Console.Write("Choose an example: ");
    if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 0 || choice > examples.Count)
    {
        Console.WriteLine("Invalid choice. Press any key..."); Console.ReadKey(); continue;
    }
    if (choice == 0) break;
    Console.Clear();
    Console.WriteLine(examples[choice - 1].Title);
    Console.WriteLine(new string('-', 52));
    try { examples[choice - 1].Run(); }
    catch (Exception ex) { Console.WriteLine($"Exception: {ex.Message}"); }
    Console.WriteLine("\nPress any key to return to the menu...");
    Console.ReadKey();
}
