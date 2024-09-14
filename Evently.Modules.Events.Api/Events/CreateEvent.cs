using System;
using Evently.Modules.Events.Api.Database;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace Evently.Modules.Events.Api.Events;

public static class CreateEvent
{
    public static void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapPost("events", async (Request request, EventsDbContext context) =>
        {
            var @event = new Event
            {
                Description = request.Description,
                EndsAtUtc = request.EndsAtUtc,
                Id = request.Id,
                Location = request.Location,
                StartsAtUtc = request.StartsAtUtc,
                Status = request.Status,
                Title = request.Title
            };

            context.Events.Add(@event);

            await context.SaveChangesAsync();

            return Results.Ok(@event);
        })
        .WithTags(Tags.Events);
    }

    internal sealed class Request
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        public DateTime StartsAtUtc { get; set; }

        public DateTime? EndsAtUtc { get; set; }

        public EventStatus Status { get; set; }
    }
}
