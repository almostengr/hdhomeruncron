using System;

namespace Almostengr.HdHomerunCron
{
    public class CronJobRecording
    {
        public string ShowName { get; set; }

        // private int _hour;
        public int Hour { get; set; }

        // private int _minute;
        public int Minute { get; set; }

        // public string DayOfWeek { get; set; }
        public int DayOfWeek { get; set; }
        public string ChannelNumber { get; set; }

        // private int _durationMinutes;
        public int DurationMinutes { get; set; }
    }
}