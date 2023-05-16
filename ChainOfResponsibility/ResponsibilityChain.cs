public abstract class ResponsibilityChain
{
    protected ResponsibilityChain Next { get; set; }
    public abstract Task<Result> DoWork(ChainContext name);
    public ResponsibilityChain SetNext<TChain>(TChain identifier)
        where TChain : ResponsibilityChain
    {
        return Next = identifier;
    }
}
