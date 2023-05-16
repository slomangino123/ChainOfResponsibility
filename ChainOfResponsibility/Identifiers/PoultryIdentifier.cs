public class PoultryIdentifier : ResponsibilityChain
{
    private readonly HashSet<string> _poultry = new HashSet<string>()
    {
        "Chicken",
        "Turkey",
        "Duck"
    };

    public override async Task<Result> DoWork(ChainContext ctx)
    {
        if (_poultry.Contains(ctx.Dish))
        {
            Console.WriteLine($"{GetType().Name} identified {ctx.Dish}");
            return Result.Success(FoodType.Poultry);
        }

        return await Next.DoWork(ctx);
    }
}
