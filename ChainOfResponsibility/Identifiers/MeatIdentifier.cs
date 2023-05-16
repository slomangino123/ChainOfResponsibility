public class MeatIdentifier : ResponsibilityChain
{
    private readonly HashSet<string> _meats = new HashSet<string>()
    {
        "Steak",
        "Bacon",
        "Veal"
    };

    public override async Task<Result> DoWork(ChainContext ctx)
    {
        if (_meats.Contains(ctx.Dish))
        {
            Console.WriteLine($"{GetType().Name} identified {ctx.Dish}");
            return Result.Success(FoodType.Meat);
        }

        return await Next.DoWork(ctx);
    }
}
