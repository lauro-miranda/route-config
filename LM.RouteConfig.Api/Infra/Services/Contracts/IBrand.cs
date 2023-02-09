namespace LM.RouteConfig.Api.Infra.Services.Contracts
{
    public interface IBrand
    {
        string Name { get; }

        bool HasValue { get; }
    }
}