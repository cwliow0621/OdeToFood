using System.IO;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.PlatformAbstractions;
using Microsoft.AspNetCore.Builder;

namespace Microsoft.AspNet.Builder
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseNodeModules(this IApplicationBuilder app, ApplicationEnvironment env)
        {
            var path = Path.Combine(env.ApplicationBasePath,"node_modules");
            var provider = new PhysicalFileProvider(path);

            var options = new StaticFileOptions();
            options.RequestPath = "/node_models";
            options.FileProvider = provider;
            //app.UseStaticFiles(options);
            return app;
        }
    }
}

