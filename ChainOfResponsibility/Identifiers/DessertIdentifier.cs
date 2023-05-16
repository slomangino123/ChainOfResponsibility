public class DessertIdentifier : ResponsibilityChain
{
    private readonly HashSet<string> _desserts = new HashSet<string>()
    {
        "Apple Pie",
        "Banana Split",
        "Orange Creamsicle Icecream"
    };

    public override async Task<Result> DoWork(ChainContext ctx)
    {
        if (_desserts.Contains(ctx.Dish))
        {
            Console.WriteLine($"{GetType().Name} identified {ctx.Dish}");
            return Result.Success(FoodType.Dessert);
        }

        return await Next.DoWork(ctx);
    }
}
