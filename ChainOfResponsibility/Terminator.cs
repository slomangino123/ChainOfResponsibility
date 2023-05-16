public class Terminator : ResponsibilityChain
{
    public override Task<Result> DoWork(ChainContext name)
    {
        return Task.FromResult(Result.Fail);
    }
}