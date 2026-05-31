namespace ECommerce.API.Extensions;

public static class SwaggerExtensions
{
    public static IServiceCollection AddSwaggerService(this IServiceCollection services)
    {
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "ECommerce API",
                Version = "v1",
                Description = "ECommerce API"
            });

            const string schemeId = "bearer";

            options.AddSecurityDefinition(schemeId, new OpenApiSecurityScheme
            {
                Name = "Authorization",
                Description = "Enter JWT Bearer token only",
                In = ParameterLocation.Header,
                Type = SecuritySchemeType.Http,
                Scheme = schemeId,
                BearerFormat = "JWT"
            });

            options.OperationFilter<AuthOperationFilter>();
        });

        return services;
    }

    public static WebApplication UseSwaggerWithVersioning(this WebApplication app)
    {
        app.UseSwagger();
        app.UseSwaggerUI(options =>
        {
            options.SwaggerEndpoint("/swagger/v1/swagger.json", "ECommerce API V1");
        });

        return app;
    }
}