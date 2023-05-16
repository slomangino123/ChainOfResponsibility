public class VegetableIdentifier : ResponsibilityChain
{
    private readonly HashSet<string> _vegetables = new HashSet<string>()
    {
        "Cucumber",
        "Pepper",
        "Broccoli"
    };

    public override async Task<Result> DoWork(ChainContext ctx)
    {
        if (_vegetables.Contains(ctx.Dish))
        {
            Console.WriteLine($"{GetType().Name} identified {ctx.Dish}");
            return Result.Success(FoodType.Vegetable);
        }
        
        return await Next.DoWork(ctx);
    }
}
