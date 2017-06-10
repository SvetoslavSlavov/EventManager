namespace Events.Web.Models
{
    using System;
    using System.Linq.Expressions;
    using Data;
    using Service;

    public class EventDetailsViewModel
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public string AuthorId { get; set; }
        

        public static Expression<Func<Event, EventDetailsViewModel>> ViewModel
        {
            get
            {
                return e => new EventDetailsViewModel()
                {
                    Id = e.Id,
                    Description = e.Description,
                    AuthorId = e.Author.Id
                };
            }
        }
    }
}
