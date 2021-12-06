using System;
using System.Collections.Generic;
using System.Text;

namespace B24
{
    public class ProjectResult
    {
        public string ID { get; set; }
        public string SITE_ID { get; set; }
        public string NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public DateTime DATE_CREATE { get; set; }
        public DateTime DATE_UPDATE { get; set; }
        public string ACTIVE { get; set; }
        public string VISIBLE { get; set; }
        public string OPENED { get; set; }
        public string CLOSED { get; set; }
        public string SUBJECT_ID { get; set; }
        public string OWNER_ID { get; set; }
        public string KEYWORDS { get; set; }
        public string NUMBER_OF_MEMBERS { get; set; }
        public DateTime DATE_ACTIVITY { get; set; }
        public string SUBJECT_NAME { get; set; }
        public string PROJECT { get; set; }
        public string IS_EXTRANET { get; set; }
    }

    public class ProjectTime
    {
        public double start { get; set; }
        public double finish { get; set; }
        public double duration { get; set; }
        public double processing { get; set; }
        public DateTime date_start { get; set; }
        public DateTime date_finish { get; set; }
    }

    public class B24Project
    {
        public List<ProjectResult> result { get; set; }
        public int total { get; set; }
        public ProjectTime time { get; set; }
    }
}
