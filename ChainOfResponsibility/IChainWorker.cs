public interface IChainWorker
{
    Task<Result> DoWork(ChainContext name);
}
