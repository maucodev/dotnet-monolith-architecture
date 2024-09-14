using Evently.Api.Extensions;
using Evently.Modules.Events.Infrastructure;

#pragma warning disable S6966

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services.AddEventsModule(builder.Configuration);

WebApplication app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.ApplyMigrations();
}

EventsModule.MapEndpoints(app);

app.UseHttpsRedirection();

app.Run();
