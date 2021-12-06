using System;
using System.Collections.Generic;
using System.Text;

namespace B24
{
    public class SonetGroupUserResult
    {
        public string USER_ID { get; set; }
        public string ROLE { get; set; }
    }

    public class SonetGroupUserTime
    {
        public double start { get; set; }
        public double finish { get; set; }
        public double duration { get; set; }
        public double processing { get; set; }
        public DateTime date_start { get; set; }
        public DateTime date_finish { get; set; }
    }

    public class B24SonetGroupUser
    {
        public List<SonetGroupUserResult> result { get; set; }
        public SonetGroupUserTime time { get; set; }
    }
}
