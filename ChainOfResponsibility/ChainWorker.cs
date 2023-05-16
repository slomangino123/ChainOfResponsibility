public abstract class ChainWorker : IChainWorker
{
    protected ResponsibilityChain chain { get; private set; }

    public ChainWorker(params ResponsibilityChain[] links)
    {
        chain = BuildChain(links);
    }
    private static ResponsibilityChain BuildChain(ResponsibilityChain[] links)
    {
        links.Aggregate((a, b) => a.SetNext(b));
        return links[0];
    }

    public async Task<Result> DoWork(ChainContext ctx)
    {
        var result = await chain.DoWork(ctx);
        if (result.FoodType != null)
        {
            Console.WriteLine($"{ctx.Dish} identified as: {result.FoodType}");
        }
        else
        {
            Console.WriteLine($"Unable to identify food: {ctx.Dish}");
        }

        Console.WriteLine("--------------------------------------------");

        return result;
    }
}
