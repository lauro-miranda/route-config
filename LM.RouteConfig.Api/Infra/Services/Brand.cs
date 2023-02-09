using LM.RouteConfig.Api.Infra.Services.Contracts;

namespace LM.RouteConfig.Api.Infra.Services
{
    public class Brand : IBrand
    {
        Brand() { }
        public Brand(IHttpContextAccessor httpContextAccessor)
        {
            if (httpContextAccessor == null)
                throw new ArgumentNullException(nameof(httpContextAccessor));

            Initialize(httpContextAccessor);
        }

        public string Name { get; private set; }

        public bool HasValue => !string.IsNullOrEmpty(Name);

        void Initialize(IHttpContextAccessor httpContextAccessor)
        {
            if (httpContextAccessor.HttpContext == null)
                return;

            var path = httpContextAccessor.HttpContext.Request.Path;

            if (path == null || path.Value == null) return;

            Name = path.Value.Split("/").LastOrDefault();
        }
    }
}