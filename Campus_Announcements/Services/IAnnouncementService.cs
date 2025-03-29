using Campus_Announcements.Models;

namespace Campus_Announcements.Services
{
    public interface IAnnouncementService
    {
        List<Announcement> GetAnnouncements();
        void AddAnnouncement(Announcement announcement);
    }
}
