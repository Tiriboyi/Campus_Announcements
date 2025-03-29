using Campus_Announcements.Models;

namespace Campus_Announcements.Services
{
    public class AnnouncementServices : IAnnouncementService
    {
        public void AddAnnouncement(Announcement announcement)
        {
            throw new NotImplementedException();
        }

        public List<Announcement> GetAnnouncements()
        {
            //Use inmemory data for now
            return new List<Announcement>
            {
                new Announcement
                {
                    Id = 1,
                    Title = "Announcement 1",
                    Content = "This is the content of announcement 1",
                    DatePosted = DateTime.Now
                },
                new Announcement
                {
                    Id = 2,
                    Title = "Announcement 2",
                    Content = "This is the content of announcement 2",
                    DatePosted = DateTime.Now
                },
                new Announcement
                {
                    Id = 3,
                    Title = "Announcement 3",
                    Content = "This is the content of announcement 3",
                    DatePosted = DateTime.Now
                }
            };
        }
    }
}
