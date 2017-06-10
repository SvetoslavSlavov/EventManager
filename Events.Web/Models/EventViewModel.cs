namespace Events.Web.Models
{
    using System;
    using System.Linq.Expressions;
    using Service;

    public class EventViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }

        public TimeSpan? Duration { get; set; }

        public string Author { get; set; }

        public string Location { get; set; }

        public static Expression<Func<Event, EventViewModel>> ViewModel
        {
            get
            {
                return e => new EventViewModel()
                {
                    Id = e.Id,
                    Name = e.Name,
                    StartDateTime = e.StartDateTime,
                    EndDateTime = e.EndDateTime,
                    Duration = e.Duration,
                    Location = e.Location,
                    Author = e.Author.FullName
                };
            }
        }
    }
}