using System;
using System.Collections.Generic;
using System.Text;

namespace works.ei8.Cortex.Diary.Common
{
    // DEL: Unnecessarily duplicated from EventSourcing.Common, remove upon NotificationData refactor
    public class Notification
    {
        public long SequenceId { get; set; }

        public string Timestamp { get; set; }

        public string TypeName { get; set; }

        public string Id { get; set; }

        public int Version { get; set; }

        public string AuthorId { get; set; }

        public string Data { get; set; }
    }
}
