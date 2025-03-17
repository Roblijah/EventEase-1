using System.Collections.Generic;
using System.Threading.Tasks;
using EventEase.Models;

namespace EventEase.Services
{
    public class EventService
    {
        private List<EventModel> events;

        public EventService()
        {
            // Initialize with some mock data
            events = new List<EventModel>
            {
                new EventModel { Name = "Corporate Retreat", Date = "2023-11-15", Location = "New York" },
                new EventModel { Name = "Annual Gala", Date = "2023-12-10", Location = "Los Angeles" },
                new EventModel { Name = "Tech Conference", Date = "2024-01-20", Location = "San Francisco" }
            };
        }

        public Task<List<EventModel>> GetEventsAsync()
        {
            return Task.FromResult(events);
        }

        public Task<EventModel> GetEventByNameAsync(string name)
        {
            var eventItem = events.Find(e => e.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            return Task.FromResult(eventItem);
        }

        public Task AddEventAsync(EventModel newEvent)
        {
            events.Add(newEvent);
            return Task.CompletedTask;
        }
    }
}