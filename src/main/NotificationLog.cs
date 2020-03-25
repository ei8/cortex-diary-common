using System.Collections.ObjectModel;

namespace works.ei8.Cortex.Diary.Common
{
    // DEL: Unnecessarily duplicated from EventSourcing.Common, remove upon NotificationData refactor
    public class NotificationLog
    {
        public NotificationLog() { }

        public bool IsArchived { get; set; }

        public ReadOnlyCollection<Notification> NotificationList { get; set; }

        public int TotalNotification { get; set; }

        public int TotalCount { get; set; }

        public string NotificationLogId { get; set; }

        public string NextNotificationLogId { get; set; }

        public bool HasNextNotificationLog { get; set; }

        public string PreviousNotificationLogId { get; set; }

        public bool HasPreviousNotificationLog { get; set; }

        public string FirstNotificationLogId { get; set; }

        public bool HasFirstNotificationLog { get; set; }
    }
}