using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafetyReminderWF
{
    public class Compliance
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Assessment { get; set; } = "";
        public int? Frequency { get; set; }

        public DateTime? CurrentDT { get; set; }
        public DateTime? UpComingDT { get; set; }

        public decimal? Fee { get; set; }
        public bool ReminderSent { get; set; }
        public string? Remark { get; set; }

    }
}
