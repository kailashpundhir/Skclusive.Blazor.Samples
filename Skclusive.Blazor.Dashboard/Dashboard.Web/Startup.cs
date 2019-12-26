using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using Skclusive.Blazor.Dashboard.View;

namespace Skclusive.Blazor.Dashboard.Web
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDashboardView(new ViewConfigBuilder().WithResponsive(true).Build());
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<DashboardView>("app");
        }
    }
}