using System.Collections.Generic;
using AnnouncementWebsite.Models;

namespace AnnouncementWebsite.ViewModels
{
    public class AnnouncementsListingModel
    {
        public IEnumerable<Announcement> Announcements { get; set; }
        public string SearchTerm { get; set; }
    }
}
