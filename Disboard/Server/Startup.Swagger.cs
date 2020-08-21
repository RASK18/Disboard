using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Disboard.Server
{
    public partial class Startup
    {
        private const string TitleV1 = "v1";
        private static readonly string ApiName = Assembly.GetExecutingAssembly().GetName().Name;

        private static void ConfigureSwagger(IServiceCollection services)
        {
            services.AddSwaggerGen(o =>
            {
                string filePath = Path.Combine(AppContext.BaseDirectory, ApiName + ".xml");
                o.IncludeXmlComments(filePath);
                o.OperationFilter<AddDefaultValues>();
                o.SwaggerDoc(TitleV1, new OpenApiInfo { Title = ApiName, Version = "v1" });
            });

            services.AddSwaggerGenNewtonsoftSupport();
        }

        private static void ConfigureSwagger(IApplicationBuilder app)
        {
            app.UseSwagger();

            app.UseSwaggerUI(o =>
            {
                o.DisplayOperationId();
                o.DocumentTitle = ApiName;
                o.SwaggerEndpoint($"/swagger/{TitleV1}/swagger.json", " V1");
            });
        }
    }

    public class AddDefaultValues : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            IList<OpenApiSchema> schemas = context.SchemaRepository.Schemas
                .Select(s => s.Value)
                .SelectMany(v => v.Properties)
                .Select(p => p.Value)
                .Where(v => v.Default != null)
                .ToList();

            foreach (OpenApiSchema schema in schemas)
                schema.Example = schema.Default;
        }
    }


}
