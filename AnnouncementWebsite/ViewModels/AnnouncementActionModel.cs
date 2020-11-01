using System;

namespace AnnouncementWebsite.ViewModels
{
    public class AnnouncementActionModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }

        public AnnouncementActionModel()
        {
            DateAdded = DateTime.Now;
        }
    }
}
