using System;
using Microsoft.AspNetCore.Components;

namespace EventEase.Components
{
    public partial class EventCard
    {
        [Parameter]
        public string EventName { get; set; }

        [Parameter]
        public DateTime EventDate { get; set; }

        [Parameter]
        public string EventLocation { get; set; }

        protected override void OnParametersSet()
        {
            ValidateInputs();
        }

        private void ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(EventName))
            {
                throw new ArgumentException("Event name cannot be empty.");
            }

            if (EventDate == default)
            {
                throw new ArgumentException("Event date is not valid.");
            }

            if (string.IsNullOrWhiteSpace(EventLocation))
            {
                throw new ArgumentException("Event location cannot be empty.");
            }
        }
    }
}