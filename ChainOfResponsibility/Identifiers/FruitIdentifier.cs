public class FruitIdentifier : ResponsibilityChain
{
    private readonly HashSet<string> _fruits = new HashSet<string>()
    {
        "Apple",
        "Banana",
        "Orange"
    };

    public override async Task<Result> DoWork(ChainContext ctx)
    {
        if (_fruits.Contains(ctx.Dish))
        {
            Console.WriteLine($"{GetType().Name} identified {ctx.Dish}");
            return Result.Success(FoodType.Fruit);
        }

        return await Next.DoWork(ctx);
    }
}
