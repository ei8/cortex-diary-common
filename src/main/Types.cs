using System;
using System.Collections.Generic;
using System.Text;

namespace ei8.Cortex.Diary.Common
{
    public enum RelativeType
    {
        NotSet,
        Postsynaptic,
        Presynaptic
    }

    [Flags]
    public enum RelativeValues
    {
        None = 0x0,
        Postsynaptic = 0x1,
        Presynaptic = 0x2,
        All = Postsynaptic | Presynaptic
    }

    [Flags]
    public enum ActiveValues
    {
        None = 0x0,
        Active = 0x1,
        Inactive = 0x2,
        All = Active | Inactive
    }

    // DEL: Unnecessarily duplicated from EventSourcing.Common, remove upon NotificationData refactor
    public struct Event
    {
        public struct NotificationLog
        {
            public struct LogId
            {
                public struct Regex
                {
                    public const string Pattern = @"^
(?<Low>[\d]+)
\x2C
(?<High>[\d]+)
\z";
                    public struct CaptureName
                    {
                        public const string Low = "Low";
                        public const string High = "High";
                    }
                }
            }
        }
    }
}
