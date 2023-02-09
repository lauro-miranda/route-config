using LM.RouteConfig.Api.Domain.Services.Contracts;
using LM.RouteConfig.Api.Infra.Services.Contracts;

namespace LM.RouteConfig.Api.Domain.Services
{
    public class InfoService : IInfoService
    {
        IBrand Brand { get; }

        public InfoService(IBrand brand)
        {
            Brand = brand;
        }

        public string Get() => Info.Get(Brand);
    }
}