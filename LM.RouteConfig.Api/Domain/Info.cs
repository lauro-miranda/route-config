using LM.RouteConfig.Api.Infra.Services.Contracts;

namespace LM.RouteConfig.Api.Domain
{
    public class Info
    {
        static Dictionary<string, string> Values = new Dictionary<string, string>()
        {
            {
                "simple", "Informação resumida."
            },
            {
                "full", "Informação completa."
            }
        };

        public static string Get(IBrand brand)
        {
            if (!brand.HasValue)
                return string.Empty;

            return Values.TryGetValue(brand.Name, out var value) ? value : string.Empty;
        }
    }
}